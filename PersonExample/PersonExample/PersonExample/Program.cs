using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Wilma Jones", 60);
            Console.WriteLine("The name is {0}", p1.getName());
            Console.WriteLine("The age is {0}", p1.getAge());
            Console.WriteLine("What would you like the name to be set to?");
            p1.setName(Console.ReadLine());
            Console.WriteLine("What would you like the age to be set to?");
            p1.setAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(p1); // Note I don't need to call ToString explicitly

            Address a1 = new Address("HSFC","Foley Lane", "Hereford", "HR1 1LR");
            Console.WriteLine("The name is {0}", a1.getHouseNameNumber());
            Console.WriteLine("The post code is {0}", a1.getPostCode());
            Console.WriteLine("What would you like the post code to be set to?");
            a1.setPostCode(Console.ReadLine());

            Console.WriteLine(a1);

            Console.ReadLine();
        }
    }
}
