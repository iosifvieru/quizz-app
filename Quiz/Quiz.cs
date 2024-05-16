using proiect_ip.Quiz.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip.Quiz
{
    public class Quiz
    {
        private IQuizState _quizState;

        private int _quizId;
        private string _quizName;
        private int _score;
        private int _maxScore;
        private bool _isVisible;
        private List<Question> _questions;
        private int _currentQuestion;


        public Quiz(int quizId, string quizName, int score = 0, int maxScore = 100, bool isVisible = false)
        {
            _quizId = quizId;
            _quizName = quizName;
            _score = score;
            _maxScore = maxScore;
            _isVisible = isVisible;
            _questions = new List<Question>();
            _currentQuestion = 0;
            _quizState = new QuizNotStartedState();
        }

        public int GetScore { get => _score; }
        public int GetMaxScore { get => _maxScore;}
        public bool IsVisible { get => _isVisible;}

        public List<Question> GetQuestions { get => _questions; }

        public String getQuestion()
        {
            return _questions[_currentQuestion].GetQuestion;
        }

        public List<Answer> getAnswers()
        {
            return _questions[_currentQuestion].GetAnswers;
        }

        public void setState(IQuizState newState)
        {
            _quizState = newState;
        }
    }
}
