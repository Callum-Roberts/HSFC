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

            while (more) &(count < 10);
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
                if (nameToSearch = "STOP") 
                more = false;

                else
                {
                    bool found = false;
                    int position = 0;

                    while (!found) &(position < count);
                    {
                        if (nameToSearch == names[position])
                        {
                            Console.WriteLine(nameToSearch + "is in position" + position);
                            found = true;
                            position = position + 1;
                        }
                    }

                }
            }

        }
    }
}
