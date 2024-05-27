using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip.Quiz
{
    public class Answer
    {
        private int _id;
        private String _answer;
        private bool _isCorrect;

        /// <summary>
        /// Constructorul clasei <class>Answer</class>
        /// </summary>
        /// <param name="id">ID-ul raspunsului</param>
        /// <param name="answer">Textul raspunsului</param>
        /// <param name="isCorrect">Flag-ul care indica daca raspunsul este corect</param>
        public Answer(int id, string answer, bool isCorrect = false)
        {
            _id = id;
            _answer = answer;
            _isCorrect = isCorrect;
        }

        /// <summary>
        /// Obtine textul raspunsului
        /// </summary>
        public String GetAnswerText { get => _answer; }
        /// <summary>
        /// Seteaza textul raspunsului
        /// </summary>
        public String SetAnswerText { set => _answer = value; }

        /// <summary>
        /// Obtine ID-ul raspunsului
        /// </summary>
        public int ID { get => _id; }
        /// <summary>
        /// Obtine / Seteaza flag-ul care indica daca raspunsul este corect.
        /// </summary>
        public bool IsCorrect {
            get => _isCorrect;
            set => _isCorrect = value;
        }
    }
}
