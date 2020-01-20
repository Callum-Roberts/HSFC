using System;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue(4);

            void DisplayMenu()
            {
                Console.WriteLine("1. Add to queue");
                Console.WriteLine("2. Remove from queue");
                Console.WriteLine("3. Lenght of queue");
                Console.WriteLine("4. Quit");
                

            }
            DisplayMenu();
            int option;
            do
            {
                Console.WriteLine("Please enter an option between 1-4");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    for (int i = 0; i < 5; i++)

                    {
                        Person P1 = new Person();

                        Console.WriteLine("Enter Name to add a person : ");
                        P1.Setname(Console.ReadLine());

                        if (q1.Enqueue(P1) == "True")
                        {
                            Console.WriteLine("Person has been added");
                        }
                        else
                        {
                            Console.WriteLine("Array is full");
                            Console.WriteLine(P1);
                        }
                    }
                }


                    










            } while (option != 4 );
            Console.WriteLine("Enter to quit");
            Console.ReadLine();
            
        }
    }
}
