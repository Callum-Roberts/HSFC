using System;

namespace Poemwordcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            WordCounter dictionary = new WordCounter(100);
            string currentWord = "";

            Console.WriteLine("Enter a word line by line, when finshed enter STOP");

            while (currentWord != "STOP")
            {
                currentWord = Console.ReadLine();
                if (currentWord != "STOP")
                {
                    dictionary.AddString(currentWord);
                }
            }

            Console.WriteLine(dictionary);
            Console.ReadLine();
        }
    }
}
