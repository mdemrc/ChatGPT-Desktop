using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class OpenAIChat
{
    private readonly string apiKey;

    public OpenAIChat(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public async Task<string> SendMessageAsync(string userInput, string chatHistory)
    {
        try
        {
            using (var client = new HttpClient())
            {
                if (string.IsNullOrWhiteSpace(apiKey))
                {
                    throw new InvalidOperationException("API anahtarı girilmemiş. Lütfen bir API anahtarı sağlayın.");
                }

                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var requestBody = new
                {
                    model = "gpt-4",
                    messages = new[]
                    {
                        new { role = "system", content = "Sen bir yardımcı asistansın. Verilen sorulara en net, sade ve efektif yanıtları vereceksin. Benim adım Yusuf. Konuşmalarımızda ismimi kullanmaya özen göstereceksin." },
                        new { role = "user", content = chatHistory },
                        new { role = "user", content = userInput }
                    }
                };

                var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"API isteği başarısız oldu. Durum Kodu: {response.StatusCode}, Mesaj: {errorContent}");
                }

                var responseJson = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(responseJson);

                return result.choices[0].message.content.ToString();
            }
        }
        catch (HttpRequestException ex)
        {
            if (ex.Message.Contains("401"))
            {
                return "Bir API anahtarı girmediniz veya geçersiz bir API anahtarı kullandınız!";
            }

            return $"İstek sırasında bir hata oluştu: {ex.Message}";
        }
        catch (InvalidOperationException ex)
        {
            return $"Hata: {ex.Message}";
        }
        catch (Exception ex)
        {
            return $"Beklenmeyen bir hata oluştu: {ex.Message}";
        }
    }
}
