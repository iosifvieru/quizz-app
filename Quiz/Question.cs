using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip.Quiz
{
    public class Question
    {
        private int _id;
        private String _question;
        private List<Answer> _answers;
        private int _score;

        /// <summary>
        /// Constructorul clasei Question
        /// </summary>
        /// <param name="id">ID-ul Intrebarii</param>
        /// <param name="question">Textul Intrebarii</param>
        /// <param name="answers">Lista cu raspunsuri</param>
        /// <param name="score">Scorul intrebarii</param>
        public Question(int id, string question, List<Answer> answers, int score = 10)
        {
            _id = id;
            _question = question;
            _answers = answers;
            _score = score;
        }

        /// <summary>
        /// Obtine textul intrebarii 
        /// </summary>
        public String GetQuestion { get => _question; } 
        /// <summary>
        /// Obtine ID-ul intrebarii
        /// </summary>
        public int ID { get => _id; }

        /// <summary>
        /// Obtine lista de raspunsuri corespunzatoare intrebarii
        /// </summary>
        public List<Answer> GetAnswers { get => _answers; } 

        /// <summary>
        /// Obtine scorul intrebarii
        /// </summary>
        public int GetScore { get => _score;}

        /// <summary>
        /// Seteaza textul intrebarii
        /// </summary>
        public String SetQuestion { set => _question = value; }

        /// <summary>
        /// Functie care determina index-ul raspsunsului corect.
        /// </summary>
        /// <returns>Index-ul raspunsului corect</returns>
        public int GetCorrectAnswerIndex ()
        {
            for(int i=0; i<_answers.Count; i++)
            {
                if (_answers[i].IsCorrect)
                    return i;
            }
            return -1;
        }

    }
}
