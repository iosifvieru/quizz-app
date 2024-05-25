using proiect_ip.Quiz.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private List<int> _userAnswers;
        private int _currentQuestion;
        private int _quizTime;
        private int _userId;

        public Quiz(int quizId, string quizName, bool isVisible = false, int score = 0, int maxScore = 100)
        {
            _quizId = quizId;
            _quizName = quizName;
            _score = score;
            _maxScore = maxScore;
            _isVisible = isVisible;
            _questions = new List<Question>();
            _currentQuestion = 0;
            _quizTime = 0;
        }

        public int GetQuizId {  get { return _quizId; } }
        public String GetTitle { get => _quizName; }
        public int GetScore { get => _score; }
        public int GetMaxScore { get => _maxScore;}
        public bool IsVisible { get => _isVisible;}

        public int GetCurrentQuestionNumber { get => _currentQuestion;}

        public List<Question> GetQuestions { get => _questions; }

        public Question GetQuestion()
        {
            return _questions[_currentQuestion];
        }

        public List<Answer> GetAnswers()
        {
            return _questions[_currentQuestion].GetAnswers;
        }

        public void SetState(IQuizState newState)
        {
            _quizState = newState;
        }

        public void SetQuestions(List<Question> questions)
        {
            _questions = questions;
            if (_questions.Count() > 0)
            {
                _userAnswers = new List<int>();
                for (int i = 0; i < _questions.Count(); i++)
                {
                    _userAnswers.Add(-1);
                }
            }
        }

        public void OpenQuiz(QuizForm quizForm, QuizController quizController)
        {
            _quizState.OpenQuiz(this,quizForm,quizController);
        }

        public void ShowQuestion()
        {
            _quizState.ShowQuestion();
        }

        public void NextQuestion()
        {
            if(_currentQuestion < _questions.Count)
            {
                _currentQuestion++;
                _quizState.ShowQuestion();
            }
        }

        public void PreviousQuestion()
        {
            if (_currentQuestion > 0)
            {
                _currentQuestion--;
                _quizState.ShowQuestion();
            }
        }

        public void SubmitAnswers()
        {
            _quizState.SubmitAnswers();
        }

        public int GetUserAnswer(int questionId)
        {
            return _userAnswers[questionId];
        }

        public List<int> GetUserAnswers { get => _userAnswers; }

        public void SetUserAnswer(int questionId, int answer)
        {
            _userAnswers[questionId] = answer;
        }

        public int GetQuizTime { get => _quizTime; }

        public void IncrementQuizTime()
        {
            _quizTime++;
        }

        public int UserId { set => _userId = value; get => _userId; }

    }
}
