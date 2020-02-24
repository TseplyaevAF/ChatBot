using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chat_Bot
{
    public class ChatBot
    {
        public string userName; // имя пользователя
        string question, // сообщение от пользователя
            answer, // ответ от бота
            path; // путь к файлу с историей сообщений
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

        public void SetAnswer(string [] answer)
        {
            history.AddRange(answer);
            File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
        }
    }
}
