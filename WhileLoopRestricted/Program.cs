using System;

namespace WhileLoopRestricted
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10.");
            Random random = new Random();
            int correctNumber = random.Next(1, 11);
            correctNumber = 3;
            int userTry = 0;
            while (guess != correctNumber && userTry < 3)
            {
                // get user input
                string input = Console.ReadLine();

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // match guess to correct number
                if (guess != correctNumber)
                {
                    // set error message
                    Console.WriteLine($"You were incorrect, you have {2 - userTry} chances left");
                    userTry++;
                   
                }
                else if (guess == correctNumber)
                {
                    Console.WriteLine("You were correct!");
                    break;
                }

            }
            //Console.WriteLine("You ran out of chances");
        }
    }
}
