namespace QuizAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany?",
                new string[]{"Paris", "Berlin", "London", "Madrid"},
                1),
                new Question("What is 1 vs 1?",
                new string[]{"2", "0", "3", "Madrid"},
                0)

            };

            Quiz myQuiz = new Quiz(questions);

            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}
