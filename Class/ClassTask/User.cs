using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class User
    {
        public string Username;
        public string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public void Login(string username, string password)
        {
            Console.WriteLine("istifadeci hesaba daxil oldu");
            if (Username == username && Password == password)
            {
                Console.WriteLine("istifadeci onceden hesaba daxil olub");
            }
            else
            {
                Console.WriteLine("istifadeci hesaba giris etmeyib");
            }
        }

        public void Logout(string username, string password)
        {
            if (Username == username && Password == password)
            {
                Console.WriteLine("istifadeci hesabdan cixis etdi");
            }
        }
    }
}
