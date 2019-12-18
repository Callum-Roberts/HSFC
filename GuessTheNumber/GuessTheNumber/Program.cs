using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int intNumber;
            int intGuess;
            int intCount = 0;

            intNumber = rnd.Next(0, 101);

            do
            {
                Console.WriteLine("Enter your guess between 1 and 100");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess > intNumber)
                {

                    Console.WriteLine("Too High");
                    intCount = intCount + 1;
                }

                if (intGuess < intNumber)
                {

                   Console.WriteLine("Too Low");
                    intCount = intCount + 1;
                }

                if (intGuess == intNumber)
                    

                {
                    intCount = intCount + 1; 
                    Console.WriteLine("You got it in {0} guesses",
                                      intCount); 

                }

            } while (intGuess != intNumber);

            Console.ReadLine(); 
















        }
    }
}
