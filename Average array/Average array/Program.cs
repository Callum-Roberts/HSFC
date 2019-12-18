
using System;

namespace Average_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int Average = 0;
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine("Please enter the mark");
                nums[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Average = ((nums[0] + nums[1] + nums[2] + nums[3] + nums[4] + nums[5] + nums[6] + nums[7] + nums[8] + nums[9])/10);
            Console.WriteLine("Your avarage mark = " + Average);

            Console.ReadLine();
        }
        }
}
