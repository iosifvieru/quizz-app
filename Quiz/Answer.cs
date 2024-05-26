using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip.Quiz
{
    public class Answer
    {
        private int _id; // vedem daca e nevoie de el
        private String _answer;
        private bool _isCorrect;

        public Answer(int id, string answer, bool isCorrect = false)
        {
            _id = id;
            _answer = answer;
            _isCorrect = isCorrect;
        }

        public String GetAnswerText { get => _answer; }
        public String SetAnswerText { set => _answer = value; }

        public int ID { get => _id; }
        public bool IsCorrect {
            get => _isCorrect;
            set => _isCorrect = value;
        }
    }
}
