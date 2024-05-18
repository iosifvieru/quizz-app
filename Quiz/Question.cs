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
        public List<Answer> GetAnswers { get => _answers; } // vedem daca facem asa

        public int GetScore { get => _score;}
    }
}
