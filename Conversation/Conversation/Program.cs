using System;

namespace Conversation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;
            int currentYear = 0;
            string Sports = "";

            Console.Write("Please enter your name:  ");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you like sports: ");
            if (Sports == "yes")
            {
                Console.WriteLine("What sports do you like: ");
            }
            if (Sports == "no")
            {
                Console.WriteLine("Why");
            }


            Sports = Console.ReadLine();
            Console.WriteLine("Hello {0}. Your age is {1}, and you were born in {2} and you said {3} to liking sports",
                              userName, userAge, currentYear - userAge, Sports) ;
            Console.ReadLine();
        }
    }
}
 