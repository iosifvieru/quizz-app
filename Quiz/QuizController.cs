/**************************************************************************
 *                                                                        *
 *  File:        Quiz.cs                                                  *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: QuizController                                           *
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
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.CodeDom.Compiler;

namespace proiect_ip.Quiz
{
    public class QuizController
    {

        private IDatabase _database;

        /// <summary>
        /// Constructorul clasei <class>QuizController</class>
        /// Obtine o instanta a bazei de date.
        /// </summary>
        public QuizController()
        {
            _database = SQLite.GetInstance();
        }

        /// <summary>
        /// Returneaza o lista cu toate quiz-urile din baza de date.
        /// </summary>
        /// <returns></returns>
        public List<Quiz> GetAllQuizzes()
        {
            string query = "SELECT * FROM quiz";
            List<Quiz> quizzesList = new List<Quiz>();

            DataTable result = _database.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string title = row["title"].ToString();


                    bool isVisible = false;
                    if (row["isVisible"] != DBNull.Value)
                    {
                        isVisible = true;
                    }

                    // rezolva un "bug" provocat de if -ul de mai sus.
                    // motivul pt. care am preferat o astfel de abordare este deoarece in baza de date pe campul "isVisible"
                    // pot exista valori nule, a.i pentru a nu strica functionalitatea deja existenta am implementat asa.
                    if (row["isVisible"].ToString() == "0")
                    {
                        isVisible = false;
                    }

                    quizzesList.Add( new Quiz(id, title, isVisible));
                }
            }

            return quizzesList;
        }

        /// <summary>
        /// Returneaza un obiect de tip <class>Quiz</class> corespunzator Id-ului din baza de date.
        /// </summary>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <returns>Un obiect de tip Quiz</returns>
        public Quiz GetQuiz(int quizId)
        {
            string query = "SELECT * FROM quiz WHERE id='" + quizId + "'";
            Quiz quiz = null;

            DataTable result = _database.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();


                bool isVisible = false;
                if (row["isVisible"] != DBNull.Value)
                {
                    isVisible = true;
                }

                quiz = new Quiz(id, title, isVisible);

            }

            return quiz;
        }

        /// <summary>
        /// Returneaza lista de raspunsuri corespunzatoare intrebarii.
        /// </summary>
        /// <param name="questionId">Id-ul intrebarii</param>
        /// <returns>O lista de raspunsuri</returns>
        public List<Answer> GetQuestionAnswers(int questionId)
        {
            string query = "SELECT * FROM answer WHERE questionId='" + questionId + "'";
            List<Answer> answers = new List<Answer>();

            DataTable result = _database.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string answerText = row["answer"].ToString();

                    bool isCorrect = false;
                    if (row["isCorrect"] != DBNull.Value)
                    {
                        isCorrect = true;
                    }

                    // repara un bug provocat de if ul de mai sus in care pune pe "true" orice valoare != NULL
                    if (row["isCorrect"].ToString() == "0")
                    {
                        isCorrect = false;
                    }

                    answers.Add(new Answer(id, answerText, isCorrect));
                }
            }

            return answers;
        }

        /// <summary>
        /// Returneaza lista de intrebari corespunzatoare quiz-ului.
        /// </summary>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <returns>O lista de intrebari</returns>
        public List<Question> GetQuizQuestions(int quizId)
        {
            string query = "SELECT * FROM question WHERE quizId='" + quizId + "'";
            List<Question> questions = new List<Question>();

            DataTable result = _database.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows) 
                {
                    int id = Convert.ToInt32(row["id"]);
                    string questionText = row["question"].ToString();
                    int score = Convert.ToInt32(row["score"]);

                    List<Answer> answers = GetQuestionAnswers(id);

                    questions.Add(new Question(id,questionText,answers,score));
                }
            }

            return questions;
        }

        /// <summary>
        /// Adauga un Quiz in baza de date
        /// </summary>
        /// <param name="titlu">Titlul quiz-ului</param>
        /// <returns>True - daca a fost inserat cu succes si false in caz contrar</returns>
        public bool AddQuiz(string titlu)
        {
            string query = "INSERT INTO quiz (title, isVisible) VALUES ('" + titlu + "', 1);";
            _database.ExecuteNonQuery(query);
            return true;
        }
        
        /// <summary>
        /// Modifica intrebarea unui quiz din baza de date.
        /// </summary>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <param name="question">Intrebarea</param>
        /// <returns>True daca a fost modificata cu succes si false in caz contrar</returns>
        public bool EditQuizQuestion(int quizId, Question question)
        {
            string query = "UPDATE question SET question='"+ question.GetQuestion + "' WHERE id='"+ question.ID +"'";

            _database.ExecuteNonQuery(query);

            foreach(Answer answer in question.GetAnswers) {
                string answerQuery = "UPDATE answer SET answer='" + answer.GetAnswerText + "', isCorrect = " + Convert.ToInt32(answer.IsCorrect) + " WHERE id='" + answer.ID + "'";
                _database.ExecuteNonQuery(answerQuery);
            }

            return true;
        }

        /// <summary>
        /// Sterge o intrebare din baza de date.
        /// </summary>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <returns>True daca a fost stearsa cu succes si false in caz contrar</returns>
        public bool DeleteQuizQuestion(int quizId)
        {
            string query = "DELETE FROM question WHERE id=' " + quizId + "'";

            _database.ExecuteNonQuery(query);
            return true;
        }

        /// <summary>
        /// Adauga o intrebare unui Quiz.
        /// </summary>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <param name="question">Intrebarea</param>
        /// <returns>True daca a fost adaugata cu succes si false in caz contrar.</returns>
        public bool AddQuizQuestion(int quizId, Question question)
        {
            string query = "INSERT INTO question (quizId, question, score) VALUES ('" + quizId + "', '" + question.GetQuestion +"', '" + question.GetScore + "')";
            _database.ExecuteNonQuery(query);

            query = "SELECT id FROM question WHERE question = '" + question.GetQuestion + "'";
            DataTable result = _database.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                
                int id = Convert.ToInt32(row["id"]);
                
                foreach(Answer answer in question.GetAnswers) {
                    query = "INSERT INTO answer (questionId, answer, isCorrect) VALUES ('" + id + "', '" + answer.GetAnswerText + "', '" + Convert.ToInt32(answer.IsCorrect) + "');";
                    _database.ExecuteNonQuery(query);
                }
            }
            return true;
        }

        // "soft" delete, doar modifica parametrul isVisible, practic il ascunde mai bine spus.
        /// <summary>
        /// Modifica flag-ul unui Quiz astfel incat sa apara doar in meniul de admin.
        /// </summary>
        /// <param name="quizId">ID-ul quizului</param>
        /// <returns>True daca a fost modificat cu succes si false in caz contrar.</returns>
        public bool DeleteQuiz(int quizId)
        {
            string query = "UPDATE quiz SET isVisible = 0 WHERE id = '" + quizId +"'";
            _database.ExecuteQuery(query);
            return true;
        }

        /// <summary>
        /// Obtine lista cu raspunsurile utilizatorului pentru un quiz
        /// </summary>
        /// <param name="userId">ID-ul utilizatorului</param>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <returns>O lista cu raspunsurile</returns>
        public List<int> GetQuizUserAnswers(int userId, int quizId)
        {
            string query = "SELECT answers FROM userAnswer WHERE userId='" + userId + "' AND quizId='" + quizId + "';";
            DataTable result = _database.ExecuteQuery(query);
            List<int> answers = new List<int>();

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                String answersString = row["answers"].ToString();

                String[] individualAnswers = answersString.Split('_');
                foreach(String answer in individualAnswers)
                {
                    if(answer != "")
                        answers.Add(Convert.ToInt32(answer));
                }
            }
            return answers;
        }

        /// <summary>
        /// Sterge progresul unui utilizator pentru un anumit quiz
        /// </summary>
        /// <param name="userId">ID-ul utilizatorului</param>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <returns>True daca a fost sters cu succes si false in caz contrar.</returns>
        public bool DeleteQuizProgress(int userId, int quizId)
        {
            string query = "DELETE FROM userAnswer WHERE userId='" + userId + "' AND quizId='" + quizId + "';";
            if (_database.ExecuteNonQuery(query) > 0)
                return true;
            return false;
        }

        /// <summary>
        /// Returneaza scorul unui utilizator pentru un anumit quiz
        /// </summary>
        /// <param name="userId">ID-ul utilizatorului</param>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <returns>Scorul sau -1 daca nu a fost completat quiz-ul.</returns>
        public int GetQuizUserScore(int userId, int quizId)
        {
            string query = "SELECT score FROM userAnswer WHERE userId='" + userId + "' AND quizId='" + quizId + "';";
            DataTable result = _database.ExecuteQuery(query);
            int score = -1;

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                if (row["score"] != DBNull.Value)
                    score = Convert.ToInt32(row["score"]);
                else
                    score = -1;
            }
            return score;
        }

        /// <summary>
        /// Returneaza timpul petrecut pe un Quiz al utilizatorului.
        /// </summary>
        /// <param name="userId">ID-ul utilizatorului</param>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <returns>Timpul petrecut pe quiz</returns>
        public int GetQuizUserTime(int userId, int quizId)
        {
            string query = "SELECT time FROM userAnswer WHERE userId='" + userId + "' AND quizId='" + quizId + "';";
            DataTable result = _database.ExecuteQuery(query);
            int time = 0;

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                time = Convert.ToInt32(row["time"]);
            }
            return time;
        }

        /// <summary>
        /// Returneaza statusul quiz-ului pentru utilizator.
        /// </summary>
        /// <param name="userId">ID-ul utilizatorului</param>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <returns>Statusul quiz-ului</returns>
        public String GetQuizStatus(int userId, int quizId)
        {
            string query = "SELECT status FROM userAnswer WHERE userId='" + userId + "' AND quizId='" + quizId + "';";
            DataTable result = _database.ExecuteQuery(query);
            String status = "Not Started";
            
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                status = row["status"].ToString();
            }
            return status;
        }

        /// <summary>
        /// Salveaza raspunsurile unui utilizator la un anumit Quiz
        /// </summary>
        /// <param name="userId">ID-ul utilizatorului</param>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <param name="answers">String-ul cu raspunsuri</param>
        /// <param name="time">Timpul petrecut pe Quiz</param>
        /// <param name="status">Statusul quiz-ului</param>
        /// <param name="score">Scorul quiz-ului</param>
        /// <returns>True daca a fost salvat cu succes si false in caz contrar.</returns>
        public bool SaveQuizAnswers(int userId, int quizId, String answers, int time, String status, int score)
        {
            string query = "SELECT * FROM userAnswer WHERE userId='" + userId + "' AND quizId='" + quizId  + "';";
            DataTable result = _database.ExecuteQuery(query);
            if(result.Rows.Count > 0)
            {;
                query = "UPDATE userAnswer SET status='" + status + "', time='" + time + "', answers='" + answers + "', score='" + score + "' WHERE userId='" + userId + "' AND quizId='" + quizId + "'';";
                if (_database.ExecuteNonQuery(query) > 0)
                    return true;
            }
            else
            {
                query = "INSERT INTO userAnswer(id, userId, quizId, answers, time, status, score) VALUES (NULL, '" + userId + "', '" + quizId + "', '" + answers + "', '" + time + "','" + status + "', '" + score + "');";
                if (_database.ExecuteNonQuery(query) > 0)
                    return true;
            }
            return false;
        }
    }
}
