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

        public Question(int id, string question, List<Answer> answers, int score = 10)
        {
            _id = id;
            _question = question;
            _answers = answers;
            _score = score;
        }

        public String GetQuestion { get => _question; } 
        public int ID { get => _id; }
        public List<Answer> GetAnswers { get => _answers; } // vedem daca facem asa

        public int GetScore { get => _score;}

        public String SetQuestion { set => _question = value; }

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
