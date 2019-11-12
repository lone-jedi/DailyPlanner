using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner
{
    class User
    {
        public bool UserRegistration { get; set; }
        private const string RegistrationStr = "Пользователь успешно зарегистрирован!";
        string name { get; set; }
        string surname { get; set; }
        string birsday { get; set; }
        char pol { get; set; }
        string theme { get; set; }

        public User(string Name, string Surname, string Birsday, char Pol, string Theme)
        {
            this.name = Name;
            this.surname = Surname;
            this.birsday = Birsday;
            this.pol = Pol;
            this.theme = Theme;
            UserRegistration = false;
        }

        public string Registration()
        {
            string postData = "btn_auth=True";
            postData += "&name=" + name;
            postData += "&surname=" + surname;
            postData += "&birsday=" + birsday;
            postData += "&pol=" + pol;
            postData += "&theme=" + theme;

            string responseString = Post.PostRequest(postData);
            //Проверка
            if (responseString.Contains(RegistrationStr))
            {
                UserRegistration = true;
                return RegistrationStr;
            }
            else
            {
                UserRegistration = false;
                return responseString;
            }

        }
    }
}
