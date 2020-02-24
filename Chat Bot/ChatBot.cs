using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Chat_Bot
{
    public class ChatBot
    {
        public string userName; // имя пользователя
        string question; // сообщение от пользователя
        public string path; // путь к файлу с историей сообщений
        public List<string> history = new List<string>(); // хранение истории

        public ChatBot()
        {

        }

        public void SearchFile(string userName)
        {
            path = userName + ".txt"; // запись пути
            this.userName = userName;

            try
            {
                //попытка загрузки существующей базы
                history.AddRange(File.ReadAllLines(path, Encoding.GetEncoding(1251)));
            }
            catch
            {
                // если файл не существует, создаем его
                File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
            }
        }

        public void AddToHistory(string [] answer)
        {
            history.AddRange(answer);
            File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
        }

        // проверка сообщения от пользователя и его обработка
        public string CheckQuestion(string userQuestion)
        {
            userQuestion = userQuestion.ToLower(); // переводим в нижний регистр
            Regex regex1 = new Regex(@"привет(\w*)");
            Regex regex2 = new Regex(@"который час(\w*)");
            Regex regex3 = new Regex(@"сколько времени(\w*)");
            if (regex1.IsMatch(userQuestion))
                return "Привет, " + this.userName + "!";
            if ((regex2.IsMatch(userQuestion)) || (regex3.IsMatch(userQuestion)))
                return "Сейчас: " + DateTime.Now.Hour.ToString() + ":" +
                    DateTime.Now.Minute.ToString() + ":" +
                    DateTime.Now.Second.ToString();

            return "Извините, я вас не понимаю";
        }
    }
}
