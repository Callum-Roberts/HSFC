using System;

namespace PersonDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p1 = new Person();

            Console.WriteLine("Please enter your name ");
            p1.setName(Console.ReadLine());

            Console.WriteLine("Please enter your age ");
            p1.setAge(Convert.ToInt32(Console.ReadLine()));

            Address a1 = new Address(); 

            Console.WriteLine("What is your house name or number ");
            a1.sethouseNameNumber(Console.ReadLine());

            Console.WriteLine("What street do you live on ");
            a1.sethouseNameNumber(Console.ReadLine());





            Console.WriteLine(p1);

            Console.ReadLine();

            Coach myCoach = new coach();
            for (int i = 0; i < 10; i++)

            {
                
            }



        }
    }
}
