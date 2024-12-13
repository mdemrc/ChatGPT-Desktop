using System;
using System.Windows.Forms;

namespace ChatGBT_Desktop
{
    public partial class Form1 : Form
    {
        private OpenAIChat openAIChat;
        private string chatHistory = "";

        public Form1()
        {
            InitializeComponent();
            // OpenAI API anahtarýný burada gir
            openAIChat = new OpenAIChat("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");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            {
                string userInput = rtbPromptInput.Text;

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    MessageBox.Show("Lütfen bir mesaj girin.");
                    return;
                }

                // Kullanýcý mesajýný göster - Yusuf'u kalýn yap
                rtbChat.SelectionFont = new System.Drawing.Font(rtbChat.Font, System.Drawing.FontStyle.Bold);
                rtbChat.AppendText("Yusuf: ");
                rtbChat.SelectionFont = new System.Drawing.Font(rtbChat.Font, System.Drawing.FontStyle.Regular);
                rtbChat.AppendText($"{userInput}\n");

                // API'den yanýt al
                string response = await openAIChat.SendMessageAsync(userInput, chatHistory);

                // Yanýtý sohbet geçmiþine ve ekrana ekle - ChatGBT'yi kalýn yap
                chatHistory += $"User: {userInput}\nAssistant: {response}\n";
                rtbChat.SelectionFont = new System.Drawing.Font(rtbChat.Font, System.Drawing.FontStyle.Bold);
                rtbChat.AppendText("ChatGBT: ");
                rtbChat.SelectionFont = new System.Drawing.Font(rtbChat.Font, System.Drawing.FontStyle.Regular);
                rtbChat.AppendText($"{response}\n");

                // Prompt giriþini temizle
                rtbPromptInput.Clear();
            }
        }


        private void btnNewSession_Click_1(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Show();
            newForm.Show();
            this.Hide();


        }
    }
}
