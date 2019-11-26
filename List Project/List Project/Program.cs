using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            list mylist = new list();

            

            for (int i = 0; i < 5; i++)

            {
                ListExercises1 L1 = new ListExercises1();

                Console.WriteLine("Enter Name to add a person : ");
                L1.setName(Console.ReadLine());

                if (mylist.AddPerson(L1) == true)
                {
                    Console.WriteLine("Person has been added");
                }
                else
                {
                    Console.WriteLine("Coach full");
                    
                    Console.WriteLine(mylist.getNumOfPassengers());
                     
                }


            }

            Console.WriteLine("Please enter the name you would like to find and remove ");
            string nameofperson = Console.ReadLine();

            Console.WriteLine(nameofperson + "There position is " + mylist.GetPositionByName(nameofperson));
            


            Console.ReadLine();
        }









    }
    }

