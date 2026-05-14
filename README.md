# ChatGBT Desktop

[![.NET](https://img.shields.io/badge/.NET-WinForms-512BD4?logo=dotnet)](https://dotnet.microsoft.com)
[![OpenAI](https://img.shields.io/badge/API-Chat%20Completions-412991)](https://platform.openai.com)

## English

### Overview

**ChatGBT Desktop** is a compact Windows desktop client for OpenAI’s Chat Completions HTTP API. It keeps a simple in-memory chat history, forwards user messages to `https://api.openai.com/v1/chat/completions`, and displays assistant replies in a classic WinForms UI. The scope is intentionally narrow: demonstrate how to wire `HttpClient`, JSON serialization, and Bearer authentication in C# without dragging in heavy SDK dependencies.

### Highlights

- Lightweight `OpenAIChat` helper that posts JSON payloads and parses the assistant `content` field.
- Separate “new conversation” flow clears context so multiple short sessions can run in one app instance.
- API key is injected in code as a **placeholder** (`YOUR_API_KEY_HERE` in `Form1.cs`); replace it with your own key or refactor to read from user settings or environment variables before distribution.

### Requirements

- Windows with .NET (see project `TargetFramework` in `ChatGBT Desktop.csproj`).
- Visual Studio 2022 or the .NET SDK CLI.
- A valid **OpenAI API key** (billing and rate limits apply per OpenAI policies).

### Running

1. Open `ChatGBT Desktop.sln` in Visual Studio.
2. In `Form1.cs`, set `new OpenAIChat("sk-...your-key...")` or load the key securely.
3. Build and run (F5).

### Privacy & security

- **Never commit real API keys** to Git. Prefer environment variables or Windows user-scoped secret storage for anything you share publicly.
- Conversation text is sent to OpenAI servers; do not paste confidential data into the chat box when using third-party APIs.

---

## Türkçe

### Genel bakış

**ChatGBT Desktop**, OpenAI Chat Completions REST API’sini kullanan sade bir Windows masaüstü istemcisidir. Gönderilen mesajlar JSON gövdesiyle `api.openai.com` uç noktasına iletilir ve yanıtlar WinForms arayüzünde gösterilir. Amaç; büyük SDK’lar yerine `HttpClient`, JSON serileştirme ve Bearer token ile minimal bir entegrasyon örneği sunmaktır.

### Öne çıkanlar

- `OpenAIChat` sınıfı ile HTTP POST ve yanıt çözümlemesi.
- Yeni sohbet ile bellekteki geçmişin temizlenmesi.
- API anahtarı `Form1.cs` içinde **`YOUR_API_KEY_HERE` placeholder** olarak bırakılmıştır; kendi anahtarınızı yazın veya ayar dosyası / ortam değişkenine taşıyın.

### Gereksinimler

- Windows ve projede tanımlı .NET hedef çerçevesi.
- Visual Studio veya .NET SDK.
- Geçerli **OpenAI API anahtarı** (ücret ve kota OpenAI politikalarına tabidir).

### Çalıştırma

1. `ChatGBT Desktop.sln` dosyasını açın.
2. `Form1.cs` içinde API anahtarını güvenli şekilde sağlayın.
3. Derleyip çalıştırın.

### Gizlilik ve güvenlik

- Gerçek API anahtarlarını **asla depoya gömmeyin**. Ortam değişkeni veya kullanıcı sırları daha uygundur.
- Üçüncü taraf API’ye yazdığınız metin uzak sunucuya gider; gizli veri yazmayın.
