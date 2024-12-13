namespace ChatGBT_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rtbChat = new RichTextBox();
            rtbPromptInput = new RichTextBox();
            label1 = new Label();
            btnNewSession = new Button();
            btnSend = new Button();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.AccessibleName = "rtbChat";
            rtbChat.BackColor = Color.Beige;
            rtbChat.Location = new Point(12, 12);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(910, 523);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // rtbPromptInput
            // 
            rtbPromptInput.AccessibleDescription = "rtbPromptInput";
            rtbPromptInput.Location = new Point(12, 595);
            rtbPromptInput.Name = "rtbPromptInput";
            rtbPromptInput.Size = new Size(719, 115);
            rtbPromptInput.TabIndex = 1;
            rtbPromptInput.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.IBeam;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 551);
            label1.Name = "label1";
            label1.Size = new Size(167, 33);
            label1.TabIndex = 2;
            label1.Text = "Sohbet Kutusu";
            // 
            // btnNewSession
            // 
            btnNewSession.AccessibleName = "btnNewSession";
            btnNewSession.BackColor = Color.DeepSkyBlue;
            btnNewSession.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNewSession.Location = new Point(749, 541);
            btnNewSession.Name = "btnNewSession";
            btnNewSession.Size = new Size(173, 51);
            btnNewSession.TabIndex = 3;
            btnNewSession.Text = "Yeni Sohbet Başlat";
            btnNewSession.UseVisualStyleBackColor = false;
            btnNewSession.Click += btnNewSession_Click_1;
            // 
            // btnSend
            // 
            btnSend.AccessibleName = "btnSend";
            btnSend.BackColor = Color.LemonChiffon;
            btnSend.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSend.Location = new Point(749, 598);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(173, 112);
            btnSend.TabIndex = 4;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Crimson;
            ClientSize = new Size(934, 735);
            Controls.Add(btnSend);
            Controls.Add(btnNewSession);
            Controls.Add(label1);
            Controls.Add(rtbPromptInput);
            Controls.Add(rtbChat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                     ChatGBT                                         • Yusuf Taştan Özel Versiyon •";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChat;
        private RichTextBox rtbPromptInput;
        private Label label1;
        private Button btnNewSession;
        private Button btnSend;
    }
}
