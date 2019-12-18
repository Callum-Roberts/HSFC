using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username = "";
            double UsersWeight = 0;
            double UsersHeight = 0;
             

            Console.WriteLine("Hello, What is your name ?  ");
            Username = Console.ReadLine();

            Console.WriteLine("What is your weight in kg ?  ");
            UsersWeight = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("What is your height in m to the nearesy whole number?  ");
            UsersHeight = Convert.ToDouble(Console.ReadLine());

            

            Console.WriteLine("{0},your BMI is :" + (UsersWeight / (UsersHeight * UsersHeight)),
                              Username);


            Console.ReadLine();    

            
        }


   
    }
}
