﻿using System;

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
                    Console.WriteLine("Correct! I have 2 cats.");
                else
                    Console.WriteLine($"Sorry but I don't have {answer1} cats. I actually have 2 cats.");
                bool answer2 = QuestionTwo();
                if (answer2 == true)
                    Console.WriteLine("Correct! Whereas I am not originally from Seattle, I am from Spokane, WA on the eastern side of the state.");
                else
                    Console.WriteLine("Wrong. I am in fact from Spokane Valley, WA on the east side of the state.");
                string answer3 = QuestionThree();
                if (answer3 == "lion")
                    Console.WriteLine("Wow! You got it right. My favorite exotic animal is the king of the jungle, a lion.");
                else
                    Console.WriteLine($"I'm sorry {answer3} is a good guess but wrong. My favorite exotic animal is a lion.");
                string answer4 = QuestionFour();
                if (answer4 == "Xbox")
                    Console.WriteLine("Correct. Whereas I love the Super Nintendo console, I currently only dabble in Xbox games.");
                else
                    Console.WriteLine($"No, {answer4} is not my current gaming console of choice. I love the old school Nintendo consoles but currently only game on Xbox.");
                bool answer5 = QuestionFive();
                if (answer5 == true)
                    Console.WriteLine("That's correct! I've played since I was little and will always have a passion for hopping!");
                else
                    Console.WriteLine($"Whereas {answer5} is a great sport, I love basketball.");
                Console.ReadLine();
                runGame = false;
            }
        }

        static int QuestionOne()
        {
            Console.WriteLine("To begin, try guessing how many cats I have?");
            string input = Console.ReadLine();

            int guess = Convert.ToInt32(input);

            return guess;
        }

        static bool QuestionTwo()
        {
            Console.WriteLine("Am I originally from Washington?");
            string input = Console.ReadLine();
            string answer = input.ToLower();

            if (input == "y")
                return true;
            else if
                (input == "yes")
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

        static string QuestionFour()
        {
            Console.WriteLine("Between the following gaming platforms, which do I prefer: Playstation, Xbox or Nintendo?");
            string input = Console.ReadLine();

            string answer = input.Substring(0,1).ToUpper() + input.Substring(1);

            return answer;
        }

        static bool QuestionFive()
        {
            Console.WriteLine("What do you think my favorite sport to play is?");
            string input = Console.ReadLine();
            string answer = input.ToLower();
            if (answer == "basketball")
                return true;
            else if
                (answer == "ballin")
                return true;
            else if
                (answer == "b-ball")
                return true;
            else
                return false;

            
        }
    }
}
