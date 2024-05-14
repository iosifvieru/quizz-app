/*
    Clasa User

    ID
    username
    Parola
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;

        public User(int id, string username, string password)
        {
            _id = id;
            _username = username;
            _password = password;
        }

        public int ID { get; }
        public string Username { 
            get => _username;
        }
        public string Password { 
            get => _password; 
        }
    }
}
