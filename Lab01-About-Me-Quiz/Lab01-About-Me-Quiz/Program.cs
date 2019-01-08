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
                    Console.WriteLine($"Sorry but I don't have {answer1} cats. I actually have 2 cats.");
                Console.ReadLine();
                bool answer2 = QuestionTwo();
                if (answer2 == true)
                    Console.WriteLine("Correct! Whereas I am not originally from Seattle, I am from Spokane, WA on the eastern side of the state.");
                else
                    Console.WriteLine("Wrong. I am in fact from Spokane Valley, WA on the east side of the state.");
                Console.ReadLine();
                string answer3 = QuestionThree();
                if (answer3 == "lion")
                    Console.WriteLine("Wow! You got it right. My favorite exotic animal is the king of the jungle, a lion.");
                else
                    Console.WriteLine($"I'm sorry {answer3} is a good guess but wrong. My favorite exotic animal is a lion.");
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

        static bool QuestionTwo()
        {
            Console.WriteLine("Am I originally from Washington? y/n");
            string input = Console.ReadLine();

            if (input == "y")
                return true;
            else
                return false;
        }

        static string QuestionThree()
        {
            Console.WriteLine("What is my favorite exotic animal?");
            string input = Console.ReadLine();

            string answer = input.ToLower();

            return answer;
        }
    }
}
