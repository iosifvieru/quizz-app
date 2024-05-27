using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip.Quiz
{
    public interface IQuizState
    {
        /// <summary>
        /// Deschide un Quiz si afiseaza prima intrebare.
        /// Se comporta diferit in functie de state-ul curent al quiz-ului.
        /// </summary>
        /// <param name="quiz">Quiz-ul</param>
        /// <param name="quizForm">Form-ul corespunzator quiz-ului</param>
        /// <param name="quizController">Controller-ul corespunzator quiz-urilor.</param>
        void OpenQuiz(Quiz quiz, QuizForm quizForm, QuizController quizController);

        /// <summary>
        /// Afiseaza intrebarea curenta.
        /// Sunt afisate informatii suplimentare in functie de state-ul curent al quiz-ului.
        /// </summary>
        void ShowQuestion();

        /// <summary>
        /// Se salveaza raspunsurile / se reseteaza quiz-ul.
        /// </summary>
        void SubmitAnswers();

        /// <summary>
        /// Se inchide quiz-ul.
        /// </summary>
        void CloseQuiz();
    }
}
