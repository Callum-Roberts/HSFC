using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NandC
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("  0  1  2 ");
            Console.WriteLine("0 __|__|__");
            Console.WriteLine("1 __|__|__");
            Console.WriteLine("2   |  |  ");

            Console.Write("Player 1 = O");
            Console.Write("Player 2 = X");

            Console.Write("Player 1 please enter the row then collumn of your move  ");
            Console.ReadLine();
        }
    }
}
