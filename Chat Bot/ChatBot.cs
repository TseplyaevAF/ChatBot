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
        string userName; // имя пользователя
        string path; // путь к файлу с историей сообщений
        List<string> history = new List<string>(); // хранение истории

        public ChatBot()
        {

        }

        public ChatBot(string filename)
        {
            LoadHistory(filename);
        }

        public string UserName
        {
            get
            {
                return userName;
            }
        }
        public string Path
        {
            get
            {
                return path;
            }
        }
        public List<string> History
        {
            get
            {
                return history;
            }
        }

        public void LoadHistory(string userName)
        {
            path = userName + ".txt"; // запись пути
            this.userName = userName;

            try
            {
                //попытка загрузки существующей базы
                history.AddRange(File.ReadAllLines(path, Encoding.GetEncoding(1251)));

                // Если файл был изменен не сегодня, то записываем новую дату
                // переписки
                if (File.GetLastWriteTime(path).ToString("dd.MM.yy") !=
                    DateTime.Now.ToString("dd.MM.yy"))
                {
                    String[] date = new String[] {"\n" + "Переписка от " +
                        DateTime.Now.ToString("dd.MM.yy"+ "\n")};
                    AddToHistory(date);
                }
            }
            catch
            {
                // если файл не существует, создаем его
                File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
                // отмечаем дату начала переписки
                String[] date = new String[] {"Переписка от " +
                        DateTime.Now.ToString("dd.MM.yy") + "\n"};
                AddToHistory(date);

            }
        }

        public void AddToHistory(string [] answer)
        {
            history.AddRange(answer);
            File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
        }

        // проверка сообщения от пользователя и возвращения ответа
        public string CheckQuestion(string userQuestion)
        {
            userQuestion = userQuestion.ToLower(); // переводим в нижний регистр
            {
                Regex regex = new Regex(@"привет\s?\,?\s?б{1}о{1}т{1}");
                if (regex.IsMatch(userQuestion))
                    return "Привет, " + this.userName + "!";
            }

            {
                Regex regex = new Regex(@"(?:который час\??|сколько времени\??)");
                if (regex.IsMatch(userQuestion))
                    return "Сейчас: " + DateTime.Now.Hour.ToString() + ":" +
                        DateTime.Now.Minute.ToString();
            }

            {
                Regex regex = new Regex(@"(?:какое сегодня число\??|число\??)");
                if (regex.IsMatch(userQuestion))
                    return "Сегодня: " + DateTime.Now.Day + "." + DateTime.Now.Month +
                        "." + DateTime.Now.Year;
            }

            {
                Regex regex = new Regex(@"как дела\??");
                if (regex.IsMatch(userQuestion))
                {
                    Random rnd = new Random();
                    int value = rnd.Next();
                    if ( value % 2 == 0)
                    return "Все хорошо! Спасибо, что спросили :)"; else
                    {
                        return "Как бот, чувствую себя весьма неплохо :)";
                    }
                }
            }

            {
                Regex regex = new Regex(@"(?:спасибо|благодарю)");
                if (regex.IsMatch(userQuestion))
                    return "Рад был помочь!";
            }

            {
                Regex regex = new Regex(@"(?:умножь\s?(\d+)\s?на\s?(\d+))");
                if (regex.IsMatch(userQuestion))
                {
                    return ".";
                }
                    
            }

            {
                return "Извините, я вас не понимаю";
            }
        }
    }
}
