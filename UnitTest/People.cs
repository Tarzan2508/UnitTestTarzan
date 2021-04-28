using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class People
    {
        private string login;
        private string pass;
        private string name;
        private int phone;

        public People(string login, string pass, string name, int phone)
        {
            this.login = login;
            this.pass = pass;
            this.name = name;
            this.phone = phone;

        }

        public string Login { get => login; set => login=value; }
        public string Password { get => pass; set => pass=value; }
        public string Name { get => name; set => name = value; }
        public int Phone { get => phone; set => phone = value; }
    }
}
