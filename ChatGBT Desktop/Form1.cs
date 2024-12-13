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
            // Put Your Apikey to here
            openAIChat = new OpenAIChat("YOUR_API_KEY_HERE");
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

                rtbChat.SelectionFont = new System.Drawing.Font(rtbChat.Font, System.Drawing.FontStyle.Bold);
                rtbChat.AppendText("Yusuf: ");
                rtbChat.SelectionFont = new System.Drawing.Font(rtbChat.Font, System.Drawing.FontStyle.Regular);
                rtbChat.AppendText($"{userInput}\n");

                string response = await openAIChat.SendMessageAsync(userInput, chatHistory);

                chatHistory += $"User: {userInput}\nAssistant: {response}\n";
                rtbChat.SelectionFont = new System.Drawing.Font(rtbChat.Font, System.Drawing.FontStyle.Bold);
                rtbChat.AppendText("ChatGBT: ");
                rtbChat.SelectionFont = new System.Drawing.Font(rtbChat.Font, System.Drawing.FontStyle.Regular);
                rtbChat.AppendText($"{response}\n");

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
