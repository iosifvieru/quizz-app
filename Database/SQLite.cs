/**************************************************************************
 *                                                                        *
 *  File:        SQLite.cs                                                *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: Baza de date.                                            *
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
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace proiect_ip.Database
{
    /// <summary>
    /// Implementeaza IDatabase
    /// </summary>
    public class SQLite: IDatabase
    {
        /// <summary>
        /// Este implementata folosind Singleton Design Pattern
        /// </summary>
        private static SQLite _instance;
        private SQLiteConnection database;
        
        /// <summary>
        /// Constructor.
        /// Creaza tabelele.
        /// </summary>
        private SQLite()
        {
            this.database = new SQLiteConnection("Data Source=database.db");

            CreateUserTable();
            CreateQuizesTable();
            CreateQuestionsTable();
            CreateAnswersTable();
            CreateUserAnswersTable();
        }

        /// <summary>
        /// Metoda statica ce returneaza instanta _database. 
        /// </summary>
        /// <returns>Instanta bazei de date.</returns>
        public static SQLite GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SQLite();
            }
            return _instance;
        }

        
        /// <summary>
        /// Creaza tabelul "user"
        /// </summary>
        public void CreateUserTable()
        {
            try
            {
                database.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS users (id INTEGER NOT NULL UNIQUE, username TEXT NOT NULL UNIQUE, password TEXT NOT NULL, isAdmin INTEGER, PRIMARY KEY(id AUTOINCREMENT))";
                SQLiteCommand createTable = new SQLiteCommand(createTableQuery, database);

                createTable.ExecuteNonQuery();

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                database.Close();
            }
        }

        /// <summary>
        /// Creaza tabelul "quiz"
        /// </summary>
        public void CreateQuizesTable()
        {
            try
            {
                database.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS quiz (id INTEGER NOT NULL UNIQUE, title TEXT NOT NULL UNIQUE, isVisible INTEGER, PRIMARY KEY(id AUTOINCREMENT))";
                SQLiteCommand createTable = new SQLiteCommand(createTableQuery, database);

                createTable.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                database.Close();
            }
        }

        /// <summary>
        /// Creaza tabelul question
        /// </summary>
        public void CreateQuestionsTable()
        {
            try
            {
                database.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS question (id INTEGER NOT NULL UNIQUE, quizId INTEGER NOT NULL, question TEXT NOT NULL, score INTEGER NOT NULL, PRIMARY KEY(id AUTOINCREMENT), FOREIGN KEY (quizId) REFERENCES quiz(id))";
                SQLiteCommand createTable = new SQLiteCommand(createTableQuery, database);

                createTable.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                database.Close();
            }
        }

        /// <summary>
        /// Creaza tabelul "answer"
        /// </summary>
        public void CreateAnswersTable()
        {
            try
            {
                database.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS answer (id INTEGER NOT NULL UNIQUE, questionId INTEGER NOT NULL, answer TEXT NOT NULL, isCorrect INTEGER, PRIMARY KEY(id AUTOINCREMENT), FOREIGN KEY (questionId) REFERENCES question(id))";
                SQLiteCommand createTable = new SQLiteCommand(createTableQuery, database);

                createTable.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                database.Close();
            }
        }

        /// <summary>
        /// Creaza tabelul userAnswer
        /// </summary>
        public void CreateUserAnswersTable()
        {
            try
            {
                database.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS userAnswer (id INTEGER NOT NULL UNIQUE, userId INTEGER NOT NULL, quizId INTEGER NOT NULL, answers TEXT, time INTEGER NOT NULL, status TEXT NOT NULL, score INTEGER, PRIMARY KEY(id AUTOINCREMENT), FOREIGN KEY (quizId) REFERENCES quiz(id), FOREIGN KEY (userId) REFERENCES users(id))";
                SQLiteCommand createTable = new SQLiteCommand(createTableQuery, database);

                createTable.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                database.Close();
            }
        }

        // metoda ce executa un query primit ca parametru
        // aceasta metoda trb. folosita pentru sql queries care nu returneaza date
        // ex: INSERT, UPDATE, DELETE, CREATE TABLE.
        public int ExecuteNonQuery(string query)
        {
            int noRowsAffected = 0;
            try
            {
                database.Open();
                SQLiteCommand command = new SQLiteCommand(query, database);
                noRowsAffected = command.ExecuteNonQuery();
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            finally
            {
                database.Close();
            }
            return noRowsAffected;
        }

        // metoda pentru SELECT;
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                database.Open();

                SQLiteCommand command = new SQLiteCommand(query, database);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                adapter.Fill(dataTable);
            
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                database.Close();
            }

            return dataTable;
        }
    }
}
