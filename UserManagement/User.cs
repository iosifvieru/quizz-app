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
        private int _isAdmin;

        public User(int id, string username, string password)
        {
            _id = id;
            _username = username;
            _password = password;
            _isAdmin = 0;
        }

        public User(int id, string username, string password, int admin)
        {
            _id = id;
            _username = username;
            _password = password;
            _isAdmin = admin;
        }

        public int ID { 
            get => _id; 
        }

        public string Username { 
            get => _username;
        }

        public string Password { 
            get => _password; 
        }

        public int Admin
        {
            get => _isAdmin;
            set => _isAdmin = value;
        }

        public override string ToString()
        {
            return "" + _id + " " + _username + " " + _password + " admin= " + _isAdmin;    
        }
    }
}
