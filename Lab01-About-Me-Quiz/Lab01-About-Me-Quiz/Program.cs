using System;

namespace Lab01_About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runGame = true;
            while (runGame)
            {
                runGame = true;
                Console.WriteLine("Welcome to a quiz all about me, Nate.");
                int answer1 = QuestionOne();
                if (answer1 == 2)
                {
                    Console.WriteLine("Correct! I have 2 cats.");
                }
                else
                    Console.WriteLine("Incorrect. I actually have 2 cats.");
                Console.ReadLine();
            }
        }

        static int QuestionOne()
        {
            Console.WriteLine("How many cats do I have?");
            string input = Console.ReadLine();

            int guess = Convert.ToInt32(input);

            return guess;
        }
    }
}
