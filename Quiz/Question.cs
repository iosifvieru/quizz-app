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

        public Question(int id, string question, List<Answer> answers)
        {
            _id = id;
            _question = question;
            _answers = answers;
        }

        public String GetQuestion { get => _question; } 
        public List<Answer> GetAnswers { get => _answers; } // vedem daca facem asa
    }
}
