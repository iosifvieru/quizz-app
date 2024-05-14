/* 
    User Controller

    folosit pt. operatii de CRUD pe conturi
    in modul admin? i guess
*/

using proiect_ip.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip
{
    public class UserController : IUserController
    {
        private SQLite database;
        public UserController() 
        {
            this.database = SQLite.GetInstance();

            database.CreateUserTable();
        }

        public bool addUser(User user)
        {
            // cer si eu scuze la linia de mai jos.. se mai intampla :(
            string query = "INSERT INTO users(username, password) VALUES ('" + user.Username + "', '" + user.Password + "')";

            int noRowsAffected = database.ExecuteNonQuery(query);

            // functia ExecuteNonQuery returneaza nr. de randuri "afectate" de query ul respectiv
            // daca e 0 inseamna ca username-ul se afla deja in baza date date (campul fiind UNIQUE)
            if(noRowsAffected == 0)
            {
                return false;
            }

            return true;
        }

        public bool deleteUser(int id)
        {
            string query = "DELETE FROM users WHERE id=" + id;
            database.ExecuteNonQuery(query);
            return true;
        }

        public User getUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool updateUser(int id, User user)
        {
            /*
            int id = user.ID;
            string username = user.Username;
            string password = user.Password;


            string query = "UPDATE users SET username=" + username + ", " */
            throw new NotImplementedException();
        }
    }
}
