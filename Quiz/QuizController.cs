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

namespace proiect_ip.Quiz
{
    public class QuizController
    {

        private IDatabase _database;

        public QuizController()
        {
            _database = SQLite.GetInstance();
        }

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

                    quizzesList.Add( new Quiz(id, title, isVisible));
                }
            }

            return quizzesList;
        }

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

                    answers.Add(new Answer(id, answerText, isCorrect));
                }
            }

            return answers;
        }

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

        public bool EditQuizQuestion(int quizId, Question question)
        {
            string query = "UPDATE question SET question='"+ question.GetQuestion + "' WHERE id='"+ question.ID +"'";

            _database.ExecuteNonQuery(query);

            foreach(Answer answer in question.GetAnswers) {
                string answerQuery = "UPDATE answer SET answer='" + answer.GetAnswerText + "' WHERE id='" + answer.ID + "'";
                _database.ExecuteNonQuery(answerQuery);
            }

            return true;
        }

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

        public bool DeleteQuizProgress(int userId, int quizId)
        {
            string query = "DELETE FROM userAnswer WHERE userId='" + userId + "' AND quizId='" + quizId + "';";
            if (_database.ExecuteNonQuery(query) > 0)
                return true;
            return false;
        }

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

        public bool SaveQuizAnswers(int userId, int quizId, String answers, int time, String status)
        {
            string query = "SELECT * FROM userAnswer WHERE userId='" + userId + "' AND quizId='" + quizId  + "';";
            DataTable result = _database.ExecuteQuery(query);
            if(result.Rows.Count > 0)
            {;
                query = "UPDATE userAnswer SET status='" + status + "', time='" + time + "', answers='" + answers +"';";
                if (_database.ExecuteNonQuery(query) > 0)
                    return true;
            }
            else
            {
                query = "INSERT INTO userAnswer(id, userId, quizId, answers, time, status) VALUES (NULL, '" + userId + "', '" + quizId + "', '" + answers + "', '" + time + "','" + status + "');";
                if (_database.ExecuteNonQuery(query) > 0)
                    return true;
            }
            return false;
        }

        // To be inplemented

        // Instantiem un sqlite
        // Metode pentru: addQuiz, addQuestion, addAnswer, etc. (le preluam din baza de date)

        // Practic, prima data facem un select pentru 'quiz'
        // Pentru fiecare id din quiz, facem un select pentru 'question' 
        // Pentru fiecare id din question, facem un select pentru 'answer'
        // Instantiem obiecte de tip Answer -> Question -> Quiz
        // Se apeleaza metodele corespunzatoare pentru a le adauga in liste.

        // Vor fi metode si pentru modul de admin (pentru a adauga/edita/sterge quiz-uri, intrebari, etc)
    }
}
