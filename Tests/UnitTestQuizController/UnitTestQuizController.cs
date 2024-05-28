using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using proiect_ip;
using proiect_ip.Quiz;
using System.Collections.Generic;

namespace UnitTestQuizController
{
    [TestClass]
    public class UnitTestQuizController
    {

        private QuizController _quizController = new QuizController();

        [TestMethod]
        public void TestGettingQuizFromDB()
        {
            Quiz quiz = _quizController.GetQuiz(1);

            Assert.IsNotNull(quiz);
        }

        [TestMethod]
        public void TestGettingUserAnswers()
        {
            List<int> userAnswersExpected = new List<int> { 1, 3, 2, 0, -1, -1, -1, -1, -1, -1};
            List<int> userAnswersActual = _quizController.GetQuizUserAnswers(2, 1);

            bool match = true;
            for(int i = 0; i < userAnswersExpected.Count; i++)
            {
                if (userAnswersExpected[i] != userAnswersActual[i])
                    match = false;
            }

            Assert.AreEqual(true, match);
        }

        [TestMethod]
        public void TestGetUserQuizScore()
        {
            int expectedScore = -1;
            int actualScore = _quizController.GetQuizUserScore(2, 1);

            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void TestGettingQuizStatusPositive()
        {
            String expectedValue = "In Progress";
            String actualValue = _quizController.GetQuizStatus(2, 1);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestGettingQuizStatusNegative()
        {
            String expectedValue = "In Progress";
            String actualValue = _quizController.GetQuizStatus(2, 4);

            Assert.AreNotEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestGettingQuizTimePositive()
        {
            int expectedValue = 51;
            int actualValue = _quizController.GetQuizUserTime(2, 2);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestGettingQuizTimeNegative()
        {
            int expectedValue = 51;
            int actualValue = _quizController.GetQuizUserTime(2, 4);

            Assert.AreNotEqual(expectedValue, actualValue);
        }
    }
}
