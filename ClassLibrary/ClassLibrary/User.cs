using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{


    public class User
    {
        private string mail;
        private string parola;


        public User(string mail, string parola)
        {
            this.mail = mail;
            this.parola = parola;
        }

        public string Mail { get { return mail; } set { mail = value; } }
        public string Parola { get { return parola; } set { parola = value; } }


    }
}
