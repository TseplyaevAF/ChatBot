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
            AnswerText.Select();
        }
        public void RestoreChat()
        {
            for (int i = 0; i < bot.history.Count; i++)
            {
                ChatText.Text += bot.history[i] + Environment.NewLine;
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
            if (AnswerText.Text != "")
            {
                DateTime date1 = new DateTime();
                date1 = DateTime.Now;
                string date = "[" + date1.Hour.ToString() + ":"
                    + date1.Minute.ToString() + "]";
                String[] answer = AnswerText.Text.Split(new String[] { "\r\n" },
                    StringSplitOptions.RemoveEmptyEntries);
                answer[0] = answer[0].Insert(0, date + " " + bot.userName + ": ");

                bot.AddToHistory(answer);

                for (int i = 0; i < answer.Length; i++)
                {
                    ChatText.AppendText(answer[i] + "\r\n");
                }
                AnswerText.Text = "";
                string[] botAnswer = new string[] { bot.CheckQuestion(answer[0]) };
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
            File.WriteAllText(bot.path, string.Empty);
            bot.history.Clear();
            ChatText.Text = "";
        }
    }
}
