/*
    Baza de date

    SQLite

    Singleton
*/

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
    public class SQLite: IDatabase
    {
        private static SQLite _instance;
        private SQLiteConnection database;
        private SQLite()
        {
            this.database = new SQLiteConnection("Data Source=database.db");

            CreateUserTable();
            CreateQuizesTable();
            CreateQuestionsTable();
            CreateAnswersTable();
        }

        public static SQLite GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SQLite();
            }
            return _instance;
        }

        
        // metoda ce creaza tabelul users
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

        // Metoda ce creaza tabelul quiz
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

        // Metoda ce creaza tabelul question
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

        // Metoda ce creaza tabelul answer
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
