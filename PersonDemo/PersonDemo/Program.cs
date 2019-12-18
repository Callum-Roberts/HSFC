using System;

namespace PersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p1 = new Person();
            Console.WriteLine("Please enter the name of your person");
            p1.setName(Console.ReadLine());
            Console.Write("Thank you for your details: ");
            Console.WriteLine(p1.getName());

            // lets delay exit until the user has read the screen
            Console.ReadLine();
        }
    }
}
