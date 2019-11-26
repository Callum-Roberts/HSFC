using System;

namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] computing;
            computing = new Person[22];

            for (int i = 0; i < 22; i++)

            {

                Console.WriteLine("Please enter the name");

                // create a new Person and read in name from the keyboard 

                computing[i] = new Person(Console.ReadLine());



                // set initial age to 18 

                computing[i].setAge(18);

            }

        }
    }
}
