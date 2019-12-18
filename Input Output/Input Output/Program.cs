using System;

namespace Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;
            int c = 0;
            string choice = ""; 

            Console.WriteLine("Enter a whole number :");
            a = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter another whole number :");
            b = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter one more whole number :");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in the sum you would like to do");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            
            choice = Console.ReadLine();
            if (choice == "Add") ;
            {
                Console.WriteLine("Your answer is " + (a + b + c));
            }
                
                
                
                
             Console.ReadLine();
            
        }
    }
}
