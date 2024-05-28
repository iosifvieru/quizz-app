using proiect_ip.Quiz.States;
using System;
using System.Collections.Generic;
/**************************************************************************
 *                                                                        *
 *  File:        Quiz.cs                                                  *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: Clasa ce repr. un Quizz                                   *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip.Quiz
{
    public class Quiz
    {
        private IQuizState _quizState;

        private int _quizId = -1;
        private string _quizName;
        private int _score;
        private int _maxScore;
        private bool _isVisible;
        private List<Question> _questions;
        private List<int> _userAnswers;
        private int _currentQuestion;
        private int _quizTime;
        private int _userId = -1;


        /// <summary>
        /// Constructorul pentru clasa <class>Quiz</class>
        /// </summary>
        /// <param name="quizId">ID-ul quiz-ului</param>
        /// <param name="quizName">Titlul quiz-ului</param>
        /// <param name="isVisible"><Flag-ul care indica daca este vizibil/param>
        /// <param name="score">Scorul quiz-ului</param>
        /// <param name="maxScore">Scorul maxim al quiz-ului</param>
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

        /// <summary>
        /// Obtine ID-ul quiz-ului.
        /// </summary>
        public int GetQuizId {  get { return _quizId; } }
        /// <summary>
        /// Obtine titlul quiz-ului.
        /// </summary>
        public String GetTitle { get => _quizName; }
        public int GetScore { get => _score; }
        /// <summary>
        /// Obtine scorul maxim al intrebarii.
        /// </summary>
        public int GetMaxScore { get => _maxScore;}
        /// <summary>
        /// Obtine flag-ul care indica daca intrebarea este vizibila sau nu.
        /// </summary>
        public bool IsVisible { get => _isVisible;}

        /// <summary>
        /// Obtine numarul intrebarii curente.
        /// </summary>
        public int GetCurrentQuestionNumber { get => _currentQuestion;}

        /// <summary>
        /// Obtine lista de intrebari a quiz-ului.
        /// </summary>
        public List<Question> GetQuestions { get => _questions; }

        /// <summary>
        /// Returneaza intrebarea curenta.
        /// </summary>
        /// <returns>O intrebare</returns>
        public Question GetQuestion()
        {
            return _questions[_currentQuestion];
        }

        /// <summary>
        /// Returneaza lista de raspunsuri a intrebarii curente
        /// </summary>
        /// <returns>O lista de intrebari</returns>
        public List<Answer> GetAnswers()
        {
            if (_questions[_currentQuestion] == null)
                throw new Exception("Intrebarea curenta nu exista!");
            return _questions[_currentQuestion].GetAnswers;
        }

        /// <summary>
        /// Seteaza state-ul curent al quiz-ului.
        /// </summary>
        /// <param name="newState">Noul state</param>
        public void SetState(IQuizState newState)
        {
            _quizState = newState;
        }

        /// <summary>
        /// Seteaza intrebarile pentru quiz.
        /// </summary>
        /// <param name="questions">Lista de intrebari</param>
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

        /// <summary>
        /// Deschide quiz-ul si efectueaza operatii in functie de state-ul curent.
        /// </summary>
        /// <param name="quizForm">Form-ul corespunzator quiz-ului</param>
        /// <param name="quizController">Controller-ul pentru Quiz-uri</param>
        public void OpenQuiz(QuizForm quizForm, QuizController quizController)
        {
            _quizState.OpenQuiz(this,quizForm,quizController);
        }

        /// <summary>
        /// Afiseaza intrebarea curenta.
        /// </summary>
        public void ShowQuestion()
        {
            _quizState.ShowQuestion();
        }

        /// <summary>
        /// Trece la urmatoarea intrebare.
        /// </summary>
        public void NextQuestion()
        {
            if(_currentQuestion < _questions.Count)
            {
                _currentQuestion++;
                _quizState.ShowQuestion();
            }
        }

        /// <summary>
        /// Revine la intrebarea precedenta.
        /// </summary>
        public void PreviousQuestion()
        {
            if (_currentQuestion > 0)
            {
                _currentQuestion--;
                _quizState.ShowQuestion();
            }
        }

        /// <summary>
        /// Apeleaza metoda de trimitere corespunzatoare state-ului curent.
        /// </summary>
        public void SubmitAnswers()
        {
            _quizState.SubmitAnswers();
        }

        /// <summary>
        /// Returneaza raspunsul utilizatorului pentru o intrebare data.
        /// </summary>
        /// <param name="questionId">ID-ul intrebarii</param>
        /// <returns>Raspunsul utilizatorului la intrebare</returns>
        public int GetUserAnswer(int questionId)
        {
            return _userAnswers[questionId];
        }

        /// <summary>
        /// Obtine lista cu raspunsuri ale utilizatorului.
        /// </summary>
        public List<int> GetUserAnswers { get => _userAnswers; }


        /// <summary>
        /// Seteaza lista cu raspunsuri ale utilizatorului pentru intrebarea si raspunsul dat.
        /// </summary>
        /// <param name="questionId">ID-ul intrebarii</param>
        /// <param name="answer">ID-ul raspunsului</param>
        public void SetUserAnswer(int questionId, int answer)
        {
            if (answer < -1 || answer > 3)
                throw new Exception("Index-ul raspunsului nu este valid!");
            _userAnswers[questionId] = answer;
        }

        /// <summary>
        /// Obtine valorea timpului curent al quiz-ului.
        /// </summary>
        public int GetQuizTime { get => _quizTime; }

        /// <summary>
        /// Incrementeaza valoarea timpului curent al quiz-ului.
        /// </summary>
        public void IncrementQuizTime()
        {
            _quizTime++;
        }

        /// <summary>
        /// Seteaza timpul quiz-ului curent.
        /// </summary>
        /// <param name="quizTime">Timpul (int)</param>
        public void SetQuizTime(int quizTime)
        {
            if (quizTime < 0)
                throw new Exception("Timpul quiz-ului nu poate fi negativ!");
            _quizTime = quizTime;
        }

        /// <summary>
        /// Obtine / Seteaza ID-ul userului care interactioneaza cu Quiz-ul
        /// </summary>
        public int UserId { set => _userId = value; get => _userId; }

        /// <summary>
        /// Inchide Quiz-ul curent.
        /// Apeleaza metoda corespunzatoare state-ului curent.
        /// </summary>
        public void CloseQuiz()
        {
            _quizState.CloseQuiz();
        }

    }
}
