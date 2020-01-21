using System;

namespace linearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            string tempName;

            Console.WriteLine("Please type in names, ending with STOP");
            bool more = true;
            int count = 0;

            while (more)|| (count < 10);
            {
                tempName = Console.ReadLine();
                if (tempName == "STOP")
                    more = false;
                else
                    names[count] = tempName;
            }

            string nameToSearch;
            more = true;

            while (more)
            {
                Console.WriteLine("Please enter name to seach for");
                nameToSearch = Console.ReadLine();
                if(nameToSearch ="STOP")
            }

        }
    }
}
