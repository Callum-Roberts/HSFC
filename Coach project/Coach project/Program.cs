using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach myCoach = new Coach();

            for (int i = 0; i < 5; i++)

            {
                Person p1 = new Person();
                Console.WriteLine("Enter Name to add a person : ");
                p1.setName(Console.ReadLine());

                if (myCoach.AddPerson(p1) == true)
                {
                    Console.WriteLine("Person has been added");
                }
                else
                {
                    Console.WriteLine("Coach full");
                    Console.WriteLine(myCoach.getNumOfPassengers());
                }
            }

            Console.WriteLine("Please enter the name you would like to find");
            string passenger = Console.ReadLine();

            Console.WriteLine(passenger + "There seat is " + myCoach.GetSeatByName(passenger));
           

            Console.ReadLine();


            
        }
    }
}
