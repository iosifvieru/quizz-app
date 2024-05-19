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
