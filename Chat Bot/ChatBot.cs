using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;

namespace Chat_Bot
{
    public class ChatBot : AbstractChatBot
    {
        static string userName; // имя пользователя
        string path; // путь к файлу с историей сообщений
        List<string> history = new List<string>(); // хранение истории

        List<Regex> regecies = new List<Regex>
        {
            new Regex(@"привет\s?\,?\s?б{1}о{1}т{1}"),
            new Regex(@"(?:который час\??|сколько времени\??)"),
            new Regex(@"(?:какое сегодня число\??|число\??)"),
            new Regex(@"как дела\??"),
            new Regex(@"(?:спасибо|благодарю)"),
            new Regex(@"(?:умножь(\s)?(\d+)(\s)?на(\s)?(\d+))"),
            new Regex(@"(?:раздели(\s)?(\d+)(\s)?на(\s)?(\d+))"),
            new Regex(@"(?:сложи(\s)?(\d+)(\s)?и(\s)?(\d+))"),
            new Regex(@"(?:вычти(\s)?(\d+)(\s)?из(\s)?(\d+))"),
            new Regex(@"погода")
        };

        Func<string, string> funcBuf; //буфер

        List<Func<string, string>> func = new List<Func<string, string>>
            {
                HelloBot,
                HowTime,
                HowDate,
                HowAreYou,
                ThankYou,
                MulPls,
                DivPls,
                PlusPls,
                SubPls,
                WeatherPls
            };

        static string HelloBot(string question)
        {
            return "Привет, " + userName + "!";
        }

        static string HowTime(string question)
        {
            return "Сейчас: " + DateTime.Now.ToString("HH:mm");
        }

        static string HowDate(string question)
        {
            return "Сегодня: " + DateTime.Now.ToString("dd.MM.yy");
        }

        static string HowAreYou(string question)
        {
            Random rnd = new Random();
            int value = rnd.Next();
            if (value % 2 == 0)
                return "Все хорошо! Спасибо, что спросили :)";
            else
            {
                return "Как бот, чувствую себя весьма неплохо :)";
            }
        }

        static string ThankYou(string question)
        {
            return "Рад был помочь!";
        }

        static string MulPls(string question)
        {
            question = question.Replace(" ", "");
            question = question.Substring(question.LastIndexOf('ь') + 1);
            string[] words = question.Split(new char[] { 'н', 'а' },
            StringSplitOptions.RemoveEmptyEntries);
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num1 * num2).ToString();
            }
            catch
            {
                return "извините, не могу разобрать. повторите, пожалуйста, ввод.";
            }
        }

        static string DivPls(string question)
        {
            question = question.Replace(" ", "");
            question = question.Substring(question.LastIndexOf('и') + 1);
            string[] words = question.Split(new char[] { 'н', 'а' },
            StringSplitOptions.RemoveEmptyEntries);
            try
            {
                float num1 = Convert.ToInt32(words[0]);
                float num2 = Convert.ToInt32(words[1]);
                return (num1 / num2).ToString();
            }
            catch
            {
                return "Извините, не могу разобрать. Повторите, пожалуйста, ввод.";
            }
        }

        static string PlusPls(string question)
        {
            question = question.Replace(" ", "");
            question = question.Substring(question.LastIndexOf('ж') + 2);
            string[] words = question.Split(new char[] { 'и' },
            StringSplitOptions.RemoveEmptyEntries);
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num1 + num2).ToString();
            }
            catch
            {
                return "Извините, не могу разобрать. Повторите, пожалуйста, ввод.";
            }
        }

        static string SubPls(string question)
        {
            question = question.Replace(" ", "");
            question = question.Substring(question.LastIndexOf('т') + 2);
            string[] words = question.Split(new char[] { 'и', 'з' },
            StringSplitOptions.RemoveEmptyEntries);
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num2 - num1).ToString();
            }
            catch
            {
                return "Извините, не могу разобрать. Повторите, пожалуйста, ввод.";
            }
        }

        static string WeatherPls(string question)
        {
            String[] infoWeather = FindOutWeather();
            return "Погода в городе " + infoWeather[0] + " " + infoWeather[1] + " °C"
                + ". Ветер " + infoWeather[2] + " м/c";
        }

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

        public void LoadHistory(string user)
        {
            userName = user;
            path = userName + ".txt"; // запись пути

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

        static private String[] FindOutWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Chita&units=metric&" +
                "appid=2856fc0f74411cd143093c7ac9b9a7a0";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string responce;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responce = streamReader.ReadToEnd();
            }

            WeatherResponse weather = JsonConvert.DeserializeObject<WeatherResponse>(responce);

            String [] infoWeather =  { weather.Name, weather.Main.Temp.ToString(), weather.Wind.Speed.ToString()};
            return infoWeather;
        }

        // проверка сообщения от пользователя и возвращения ответа
        public override string Answer(string userQuestion)
        {
            userQuestion = userQuestion.ToLower(); // переводим в нижний регистр
            for (int i = 0; i < regecies.Count; i++)
            {
                if (regecies[i].IsMatch(userQuestion))
                {
                    funcBuf = func[i];
                    return funcBuf(userQuestion);
                }
                
            }
            return "Извините, я вас не понимаю";
        }
    }
}
