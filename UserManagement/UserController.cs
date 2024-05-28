/**************************************************************************
 *                                                                        *
 *  File:        UserController.cs                                        *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: Clasa UserController ce e responsabila de operatii CRUD. *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using proiect_ip.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip
{
    public class UserController : IUserController
    {
        private IDatabase database;
        public UserController()
        {
            this.database = SQLite.GetInstance();
        }

        public bool addUser(User user)
        {
            // cer si eu scuze la linia de mai jos.. se mai intampla :(
            string query = "INSERT INTO users(username, password, isAdmin) VALUES ('" + user.Username + "', '" + user.Password + "', '" + user.Admin + "')";

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

            // DELETE FROM users WHERE id = id;
            string query = "DELETE FROM users WHERE id='" + id + "'";
            
            int noRowsAffected = database.ExecuteNonQuery(query);

            // daca nu s-au modificat nimic in baza de date returneaza false;
            if(noRowsAffected == 0)
            {
                return false;
            }

            return true;
        }

        public User getUser(string username)
        {
            string query = "SELECT * FROM users WHERE username='" + username + "'";
            //MessageBox.Show(query);
            User user = null;

            DataTable result = database.ExecuteQuery(query);

            // poate fi schimbat cu un if(result.Rows.Count <= 0) { }
            if(result.Rows.Count > 0)
            {
                // practic la nivelul bazei de date se executa un 
                // SELECT * FROM users WHERE username = username;
                // teoretic campul username este UNIQUE, deci ar trebui sa existe un singur camp returnat
                // dar linia de mai jos se asigura ca preia primul camp din "cele" returnate.
                DataRow row = result.Rows[0];

                // parsarea datelor primite de la db.
                int id = Convert.ToInt32(row["id"]);
                string dbUsername = row["username"].ToString();
                string password = row["password"].ToString();
                int admin = Convert.ToInt32(row["isAdmin"]);

                //user = new User(Convert.ToInt32(row["id"]), row["username"].ToString(), row["password"].ToString(), Convert.ToInt32(row["isAdmin"]));

                // crearea utilizatorului din datele primite.
                user = new User(id, dbUsername, password, admin);

                // debugging la drumu mare :))
                //MessageBox.Show(user.Password);
                //MessageBox.Show(user.ToString());
            }

            return user;
        }

        public bool updateUser(int id, User user)
        {
            string username = user.Username;
            string password = user.Password;

            // UPDATE users SET username=username, password=password, isAdmin=admin WHERE id=id;
            string query = "UPDATE users SET username='" + username + "', password='" + password + "', isAdmin='" + user.Admin + "' WHERE id='" + id + "'";
            
            int noRowsAffected = database.ExecuteNonQuery(query);

            // daca nu s-a modificat nimic in baza de date returneaza false;
            if(noRowsAffected == 0)
            {
                return false;
            }

            return true;
        }
    }
}
