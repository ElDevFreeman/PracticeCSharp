using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAppTest
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions =  questions;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz");
            int questionNumber = 1;

            foreach (Question question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoise();

                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}"); 
                }
            }
        }

        private void DisplayQuestion(Question question) 
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                QUESTION                                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();


            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("");
                Console.Write($"{i +1}.");
                Console.ResetColor();
                Console.WriteLine($"{question.Answers[i]}");
                

            }

            //if(GetUserChoise() == question.CorrectAnswerIndex)
            //{
            //    Console.WriteLine("Correct");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect");
            //}

              

        }

        private int GetUserChoise()
        {
            Console.Write($"Your answer number:");
            string input = Console.ReadLine();
            int choice = 0;
            while(!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4");
                input = Console.ReadLine();
            }

            return choice - 1;
        }

    }
}
 