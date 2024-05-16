using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip.Quiz.States
{
    public class QuizNotStartedState : IQuizState
    {
        public void OpenQuiz(Quiz quiz)
        {
            quiz.setState(new QuizInProgressState());
        }
    }
}
