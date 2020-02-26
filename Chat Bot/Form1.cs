using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chat_Bot
{
    public partial class ChatForm : Form
    {
        public ChatBot bot = new ChatBot();
        public ChatForm()
        {
            InitializeComponent();
            ChatText.ReadOnly = true;
            QuestionText.Select();
        }
        public void RestoreChat()
        {
            for (int i = 0; i < bot.History.Count; i++)
            {
                ChatText.Text += bot.History[i] + Environment.NewLine;
            }
        }

        private void ChatText_TextChanged(object sender, EventArgs e)
        {
            ChatText.SelectionStart = ChatText.Text.Length;
            ChatText.ScrollToCaret();
            ChatText.Refresh();
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (QuestionText.Text != "")
            {
                DateTime date1 = new DateTime();
                date1 = DateTime.Now;
                string date = "[" + date1.Hour.ToString() + ":"
                    + date1.Minute.ToString() + "]";
                String[] userQuestion = QuestionText.Text.Split(new String[] { "\r\n" },
                    StringSplitOptions.RemoveEmptyEntries);
                userQuestion[0] = userQuestion[0].Insert(0, date + " " + bot.UserName + ": ");

                bot.AddToHistory(userQuestion);

                for (int i = 0; i < userQuestion.Length; i++)
                {
                    ChatText.AppendText(userQuestion[i] + "\r\n");
                }
                QuestionText.Text = "";
                string[] botAnswer = new string[] { bot.CheckQuestion(userQuestion[0]) };
                botAnswer[0] = botAnswer[0].Insert(0, "Бот: ");
                ChatText.AppendText(botAnswer[0] + Environment.NewLine);

                bot.AddToHistory(botAnswer);
            }

        }

        private void ChatForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SendButton_Click(SendButton, null);
            }
        }

        private void ClearDialogButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(bot.Path, string.Empty);
            bot.History.Clear();
            ChatText.Text = "";
        }
    }
}
