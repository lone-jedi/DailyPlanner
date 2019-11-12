using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace DailyPlanner
{
    class Authorizate
    {
        public bool UserAuthorizate { get; set; }

        public const string EntranceStr = "Вы успешно авторизованны";


        string login { get; set; }
        string password { get; set; }


        
        public Authorizate(string login, string password)
        {
            this.login = login;
            this.password = password;

            UserAuthorizate = false;
        }

        public string SendToServerLoginPassword()
        {
            string postData = "btn_auth=True";
            postData += "&login=" + login;
            postData += "&password=" + password;

            string responseString = Post.PostRequest(postData);
            //Проверка
            if (responseString.Contains(EntranceStr))
            {
                UserAuthorizate = true;
                return EntranceStr;
            }
            else
            {
                UserAuthorizate = false;
                return responseString;
            }
        }

       
    }
}
