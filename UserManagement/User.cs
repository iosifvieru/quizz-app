/**************************************************************************
 *                                                                        *
 *  File:        User.cs                                                  *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: Clasa User                                               *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

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

        /// <summary>
        /// Constructor ce construieste obiectul User
        /// </summary>
        /// <param name="id">id-ul din baza de date.</param>
        /// <param name="username">numele de utilizator.</param>
        /// <param name="password">parola</param>
        public User(int id, string username, string password)
        {
            _id = id;
            _username = username;
            _password = password;
            _isAdmin = 0;
        }

        /// <summary>
        /// Constructor ce permite crearea unui utilizator in mod Administrator.
        /// </summary>
        /// <param name="id">id-ul din baza de date.</param>
        /// <param name="username">numele de utilizator.</param>
        /// <param name="password">parola</param>
        /// <param name="admin">un numar != 0 insemnand ca utilizatorul este administrator.</param>
        public User(int id, string username, string password, int admin)
        {
            _id = id;
            _username = username;
            _password = password;
            _isAdmin = admin;
        }

        /// <summary>
        /// Getter pt. ID
        /// </summary>
        public int ID { 
            get => _id; 
        }

        /// <summary>
        /// Getter pt. username
        /// </summary>
        public string Username { 
            get => _username;
        }

        /// <summary>
        /// Getter pt. password
        /// </summary>
        public string Password { 
            get => _password; 
        }

        /// <summary>
        /// Getter / Setter pt. _isAdmin.
        /// </summary>
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
