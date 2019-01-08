using System;

namespace Lab01_About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runGame = true; //controls on/off function for while loop
            while (runGame) //runs through game until the end
            {
                runGame = true;
                // all functions below call the validation funcitons which in turn call the questions
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
                Console.WriteLine($"You answered {Counter} questions right"); //display message of correct answers
                Console.ReadLine();
                runGame = false; //ends game
            }
        }
        /***************** QUESTION ONE *******************/
        /******* USER INPUT *************/
        static int QuestionOne() //takes in the user input for quesiton one to pass into validation
        {

            int guess = 0;
            bool eCheck = true;
            while (eCheck) //while loop to halt code until correct format is input/no exceptions
            {
                try //instantiates try/catch to look for exceptions
                {
                    Console.WriteLine("To begin, try guessing how many cats I have?");

                    string input = Console.ReadLine();
                    guess = Convert.ToInt32(input);
                    return guess;

                }
                catch (Exception e) //checks for any exception
                {
                    Console.WriteLine($"You've hit the following exception: {e.Message}. Try again.");
                }
            }
           
            return guess;
        }
        /******* QUESTION VALIDATION *************/
        static string CheckOne() //validates question one
        {
            int answer1 = QuestionOne(); //calls question one to gather user input
            if (answer1 == 2) //conditional statement to determine if right or wrong
            {
                Counter++; //add correct answer to counter method
                return "Correct! I have 2 cats.";
            }
            else
                return $"Sorry but I don't have {answer1} cats. I actually have 2 cats.";
        }

        /***************** QUESTION TWO *******************/
        /******* USER INPUT *************/
        static bool QuestionTwo() //gathers user input for question 2
        {
            Console.WriteLine("Am I originally from Washington?");
            string input = Console.ReadLine();
            string answer = input.ToLower();
            /**initate conditional statement to pass correct answer to question validation below**/
            if (input == "y")
                return true;
            else if
                (input == "yes")
                return true;
            else
                return false;
        }

        /******* QUESITON VALIDATION *************/
        static string CheckTwo()
        {
            bool answer2 = QuestionTwo(); //calls question two to gather user input
            //** validated correct answer below through conditiaonl statements **//
            if (answer2 == true)
            {
                Counter++; //add correct answer to counter method
                return "Correct! Whereas I am not originally from Seattle, I am from Spokane, WA on the eastern side of the state.";
            }
            else
                return "Wrong. I am in fact from Spokane Valley, WA on the east side of the state.";
        }

        /***************** QUESTION THREE *******************/
        /******* USER INPUT *************/
        static string QuestionThree()
        {
            string answer = ""; //declare variable placeholder for user input after format
            try //instantiate try statement to look for exceptions
            {
                Console.WriteLine("What is my favorite exotic animal?");
                string input = Console.ReadLine();

                answer = input.ToLower(); //convert string to all lower case
                return answer;
            }
            catch(Exception e) //looks for all exceptions
            {
                Console.WriteLine($"You've hit the following exception: {e.Message}. Try again."); //displays exception if occurs
            }
            return answer; //returns the formated user input that is in all lower case
        }

        /******* QUESTION VALIDATION *************/
        static string CheckThree()
        {
            string answer3 = QuestionThree(); //calls question three to gather user input
            if (answer3 == "lion") //conditional statements below determine if right or wrong
            {
                Counter++; //adds correct answer to counter method
                return "Wow! You got it right. My favorite exotic animal is the king of the jungle, a lion.";

            }
            else
                return $"I'm sorry {answer3} is a good guess but wrong. My favorite exotic animal is a lion.";
        }

        /***************** QUESTION FOUR *******************/
        /******* USER INPUT *************/
        static string QuestionFour()
        {
            string answer = ""; //placehodler variable for formatted user input after tyr/catch
            bool eCheck = true;
            while (eCheck) //while loop to run until there are no exceptions given
            {
                try
                {
                    Console.WriteLine("Between the following gaming platforms, which do I prefer: Playstation, Xbox or Nintendo?");
                    string input = Console.ReadLine();

                    answer = input.Substring(0, 1).ToUpper() + input.Substring(1); //formats answer to capitalize first letter in string

                    return answer;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"You've hit the following exception: {e.Message}. Try again.");
                }
            }
            return answer;

        }

        /******* QUESTION VALIDATION *************/
        static string CheckFour()
        {
            string answer4 = QuestionFour(); //calls question 4 to gather user input
            if (answer4 == "Xbox") //validates correct answer below
            {
                Counter++; //add correct answer to counter
                return "Correct. I do love the odl school Super Nintendo console, I currently only dabble in Xbox games.";
            }
            else
                return $"No, {answer4} is not my current gaming console of choice. I love the old school Nintendo consoles but currently only game on Xbox.";
        }

        /***************** QUESTION FIVE *******************/
        /******* USER INPUT *************/
        static bool QuestionFive()
        {
            Console.WriteLine("What do you think my favorite sport to play is?");
            string input = Console.ReadLine();
            string answer = input.ToLower(); //takes given user input and convert to lower case
            if (answer == "basketball") //boolean below validates if of the given three, it is correct
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
        /******* QUESTION VALIDATION *************/
        static string CheckFive()
        {
            bool answer5 = QuestionFive(); //calls question 5 to gather answer given
            if (answer5 == true) //determines answer correct or inccorect
            {
                Counter++; //adds correct answer to counter
                return "That's correct! I've played since I was little and will always have a passion for hopping!";
            }
            else
                return "That's a great sport but I love basketball.";
        }

        public static int Counter = 0; //tally all correct answers

    }
}
