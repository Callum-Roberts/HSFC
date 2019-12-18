using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit = 0;
            Console.WriteLine("What is your temperature in Fahrenheit");

            Fahrenheit = Convert.ToDouble(Console.ReadLine());

            //Answer = (Fahrenheit - 32) * (5 / 9));

            Console.WriteLine("Your temperature in Centigrade is " + (Fahrenheit - 32) * (5 / 9));

            Console.ReadLine();
        }

    }
}
