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
                Console.WriteLine(CheckOne());
                Console.WriteLine();
                Console.WriteLine(CheckTwo());
                Console.WriteLine();
                Console.WriteLine(CheckThree());
                Console.WriteLine();
                Console.WriteLine(CheckFour());
                Console.WriteLine();
                Console.WriteLine(CheckFive());
                //Console.WriteLine(Counter());
                Console.ReadLine();
                runGame = false;
            }
        }

        static int QuestionOne()
        {

            int guess = 0;
            bool eCheck = true;
            while (eCheck)
            {
                try
                {
                    Console.WriteLine("To begin, try guessing how many cats I have?");

                    string input = Console.ReadLine();
                    guess = Convert.ToInt32(input);
                    return guess;

                }
                catch (Exception e)
                {
                    Console.WriteLine($"You've hit the following exception: {e.Message}.");
                }
            }
           
            return guess;
        }

        static string CheckOne()
        {
 
            int answer1 = QuestionOne();
            if (answer1 == 2)
            {
                //count++;
                return "Correct! I have 2 cats.";
            }
            else
                return $"Sorry but I don't have {answer1} cats. I actually have 2 cats.";
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

        static string CheckTwo()
        {
            bool answer2 = QuestionTwo();
            if (answer2 == true)
                return "Correct! Whereas I am not originally from Seattle, I am from Spokane, WA on the eastern side of the state.";
            else
                return "Wrong. I am in fact from Spokane Valley, WA on the east side of the state.";
        }
        static string QuestionThree()
        {
            string answer = "";
            try
            {
                Console.WriteLine("What is my favorite exotic animal?");
                string input = Console.ReadLine();

                answer = input.ToLower();
                return answer;
            }
            catch(Exception e)
            {
                Console.WriteLine($"You've hit the following exception: {e.Message}. Try again.");
            }
            return answer;
        }

        static string CheckThree()
        {
            string answer3 = QuestionThree();
            if (answer3 == "lion")
                return "Wow! You got it right. My favorite exotic animal is the king of the jungle, a lion.";
            else
                return $"I'm sorry {answer3} is a good guess but wrong. My favorite exotic animal is a lion.";
        }
        static string QuestionFour()
        {
            string answer = "";
            bool eCheck = true;
            while (eCheck)
            {
                try
                {
                    Console.WriteLine("Between the following gaming platforms, which do I prefer: Playstation, Xbox or Nintendo?");
                    string input = Console.ReadLine();

                    answer = input.Substring(0, 1).ToUpper() + input.Substring(1);

                    return answer;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"You've hit the following exception: {e.Message}. Try again.");
                }
            }
            return answer;

        }

        static string CheckFour()
        {
            string answer4 = QuestionFour();
            if (answer4 == "Xbox")
                return "Correct. I do love the odl school Super Nintendo console, I currently only dabble in Xbox games.";
            else
                return $"No, {answer4} is not my current gaming console of choice. I love the old school Nintendo consoles but currently only game on Xbox.";
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
        static string CheckFive()
        {
            bool answer5 = QuestionFive();
            if (answer5 == true)
                return "That's correct! I've played since I was little and will always have a passion for hopping!";
            else
                return "That's a great sport but I love basketball.";
        }
    }
}
