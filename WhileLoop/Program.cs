using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10.");
            Random random = new Random();
            int correctNumber = random.Next(1, 11);

            while (guess != correctNumber )
            {
                // get user input
                string input = Console.ReadLine();

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // match guess to correct number
                if (guess != correctNumber)
                {
                    // set error message
                    Console.WriteLine("Wrong number, try again");
                }
               
            }
            Console.WriteLine("You are Correct!");
        }
    }

}
