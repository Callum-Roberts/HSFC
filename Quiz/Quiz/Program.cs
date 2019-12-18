using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string UserName = "";
            int intCountAdd = 0;
            int intCountSub = 0;
            int intCountTimes = 0;
            int intGuess;
            int intNumber1;
            int intNumber2;
            int intNumber3;
            int intNumber4;
            int intNumber5;
            int intNumber6;
            int intNumber7;
            int intNumber8;
            int intNumber9;
            int intNumber10;
            int intNumber11;
            int intNumber12;
            int intNumber13;
            int intNumber14;
            int intNumber15;
            int intNumber16;
            int intNumber17;
            int intNumber18;
            int intNumber19;
            int intNumber20;
            int intNumber21;
            int intNumber22;
            int intNumber23;
            int intNumber24;
            int intNumber25;
            int intNumber26;
            int intNumber27;
            int intNumber28;
            int intNumber29;
            int intNumber30;

            intNumber1 = rnd.Next(0, 11);
            intNumber2 = rnd.Next(0, 11);
            intNumber3 = rnd.Next(0, 11);
            intNumber4 = rnd.Next(0, 11);
            intNumber5 = rnd.Next(0, 11);
            intNumber6 = rnd.Next(0, 11);
            intNumber7 = rnd.Next(0, 11);
            intNumber8 = rnd.Next(0, 11);
            intNumber9 = rnd.Next(0, 11);
            intNumber10 = rnd.Next(0, 11);
            intNumber11 = rnd.Next(0, 11);
            intNumber12 = rnd.Next(0, 11);
            intNumber13 = rnd.Next(0, 11);
            intNumber14 = rnd.Next(0, 11);
            intNumber15 = rnd.Next(0, 11);
            intNumber16 = rnd.Next(0, 11);
            intNumber17 = rnd.Next(0, 11);
            intNumber18 = rnd.Next(0, 11);
            intNumber19 = rnd.Next(0, 11);
            intNumber20 = rnd.Next(0, 11);
            intNumber21 = rnd.Next(0, 11);
            intNumber22 = rnd.Next(0, 11);
            intNumber23 = rnd.Next(0, 11);
            intNumber24 = rnd.Next(0, 11);
            intNumber25 = rnd.Next(0, 11);
            intNumber26 = rnd.Next(0, 11);
            intNumber27 = rnd.Next(0, 11);
            intNumber28 = rnd.Next(0, 11);
            intNumber29 = rnd.Next(0, 11);
            intNumber30 = rnd.Next(0, 11);

            int answer1 = (intNumber1 + intNumber2);
            int answer2 = (intNumber3 + intNumber4);
            int answer3 = (intNumber5 + intNumber6);
            int answer4 = (intNumber7 + intNumber8);
            int answer5 = (intNumber9 + intNumber10);

            int subtractAnswer1 = (intNumber11 - intNumber12);
            int subtractAnswer2 = (intNumber13 - intNumber14);
            int subtractAnswer3 = (intNumber15 - intNumber16);
            int subtractAnswer4 = (intNumber17 - intNumber18);
            int subtractAnswer5 = (intNumber19 - intNumber20);

            int timesAnswer1 = (intNumber21 * intNumber22);
            int timesAnswer2 = (intNumber23 * intNumber24);
            int timesAnswer3 = (intNumber25 * intNumber26);
            int timesAnswer4 = (intNumber27 * intNumber28);
            int timesAnswer5 = (intNumber29 * intNumber30);



            Console.WriteLine("Welcome to the maths Quiz!");
            Console.WriteLine("Please enter your name :");
            UserName = Console.ReadLine();
            
             void DisplayMenu()
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Scores");
                Console.WriteLine("5. Quit");

            }
            DisplayMenu();
            int option;
            do
            {
                Console.WriteLine("Please enter an option between 1-5");
                option = Convert.ToInt32(Console.ReadLine());
               
                if (option == 1)
                {
                    Console.WriteLine("Welcome to our addition quiz please press ENTER to start! ");
                    Console.ReadLine();
                    Console.WriteLine("Question 1) What is {0} add {1}?", intNumber1, intNumber2);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == answer1)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountAdd = intCountAdd + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", answer1);
                    }

                    Console.WriteLine("Question 2) What is {0} add {1}?", intNumber3, intNumber4);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == answer2)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountAdd = intCountAdd + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", answer2);
                    }

                    Console.WriteLine("Question 3) What is {0} add {1}?", intNumber5, intNumber6);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == answer3)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountAdd = intCountAdd + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", answer3);
                    }

                    Console.WriteLine("Question 4) What is {0} add {1}?", intNumber7, intNumber8);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == answer4)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountAdd = intCountAdd + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", answer4);
                    }

                    Console.WriteLine("Question 5) What is {0} add {1}?", intNumber9, intNumber10);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == answer5)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountAdd = intCountAdd + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", answer5);
                    }

                    Console.WriteLine("Quiz completed");
                    if (intCountAdd > 2)
                    {
                        Console.WriteLine("Well Done {0} you completed the quiz and scored {1} points", UserName, intCountAdd);
                    }

                    else
                    {
                        Console.WriteLine("Unlucky {0} you completed the quiz and only scored {1} points", UserName, intCountAdd);
                    }
                }

                if (option == 2)
                {
                    
                        Console.WriteLine("Welcome to our subtraction quiz please press ENTER to start! ");
                        Console.ReadLine();
                        Console.WriteLine("Question 1) What is {0} - {1}?", intNumber11, intNumber12);
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == subtractAnswer1)
                        {
                            Console.WriteLine("Correct you get 1 point!");
                            intCountSub = intCountSub + 1;
                        }

                        else
                        {
                            Console.WriteLine("Incorrect the correct answer was {0}", subtractAnswer1);
                        }

                        Console.WriteLine("Question 2) What is {0} - {1}?", intNumber13, intNumber14);
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == subtractAnswer2)
                        {
                            Console.WriteLine("Correct you get 1 point!");
                            intCountSub = intCountSub + 1;
                        }

                        else
                        {
                            Console.WriteLine("Incorrect the correct answer was {0}", subtractAnswer2);
                        }

                        Console.WriteLine("Question 3) What is {0} - {1}?", intNumber15, intNumber16);
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == subtractAnswer3)
                        {
                            Console.WriteLine("Correct you get 1 point!");
                            intCountSub = intCountSub + 1;
                        }

                        else
                        {
                            Console.WriteLine("Incorrect the correct answer was {0}", subtractAnswer3);
                        }

                        Console.WriteLine("Question 4) What is {0} - {1}?", intNumber17, intNumber18);
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == subtractAnswer4)
                        {
                            Console.WriteLine("Correct you get 1 point!");
                            intCountSub = intCountSub + 1;
                        }

                        else
                        {
                            Console.WriteLine("Incorrect the correct answer was {0}", subtractAnswer4);
                        }

                        Console.WriteLine("Question 5) What is {0} - {1}?", intNumber19, intNumber20);
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == subtractAnswer5)
                        {
                            Console.WriteLine("Correct you get 1 point!");
                            intCountSub = intCountSub + 1;
                        }

                        else
                        {
                            Console.WriteLine("Incorrect the correct answer was {0}", subtractAnswer5);
                        }

                        Console.WriteLine("Quiz completed");
                        if (intCountSub > 2)
                        {
                            Console.WriteLine("Well Done {0} you completed the quiz and scored {1} points", UserName, intCountSub);
                        }

                        else
                        {
                            Console.WriteLine("Unlucky {0} you completed the quiz and only scored {1} points", UserName, intCountSub);
                        }
                    }


                if (option == 3)
                {

                    Console.WriteLine("Welcome to our multipcation quiz please press ENTER to start! ");
                    Console.ReadLine();
                    Console.WriteLine("Question 1) What is {0} * {1}?", intNumber21, intNumber22);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == timesAnswer1)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountTimes = intCountTimes + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", timesAnswer1);
                    }

                    Console.WriteLine("Question 2) What is {0} - {1}?", intNumber23, intNumber24);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == timesAnswer2)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountTimes = intCountTimes + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", timesAnswer2);
                    }

                    Console.WriteLine("Question 3) What is {0} - {1}?", intNumber25, intNumber26);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == timesAnswer3)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountTimes = intCountTimes + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", timesAnswer3);
                    }

                    Console.WriteLine("Question 4) What is {0} - {1}?", intNumber27, intNumber28);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == timesAnswer4)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountTimes = intCountTimes + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", timesAnswer4);
                    }

                    Console.WriteLine("Question 5) What is {0} - {1}?", intNumber29, intNumber30);
                    intGuess = Convert.ToInt32(Console.ReadLine());
                    if (intGuess == timesAnswer1)
                    {
                        Console.WriteLine("Correct you get 1 point!");
                        intCountTimes = intCountTimes + 1;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect the correct answer was {0}", timesAnswer5);
                    }

                    Console.WriteLine("Quiz completed");
                    if (intCountTimes > 2)
                    {
                        Console.WriteLine("Well Done {0} you completed the quiz and scored {1} points", UserName, intCountTimes);
                    }

                    else
                    {
                        Console.WriteLine("Unlucky {0} you completed the quiz and only scored {1} points", UserName, intCountTimes);
                    }
                }

                if (option == 4)
                {
                    Console.WriteLine("Here are all your scores for each quiz !");
                    Console.WriteLine("Addition score = {0}", intCountAdd);
                    Console.WriteLine("Subtraction score = {0}", intCountSub);
                    Console.WriteLine("Addition score = {0}", intCountTimes);
                    Console.WriteLine("Your total score = " + (intCountAdd + intCountSub + intCountTimes)); 
                }

                } while (option != 5);
            Console.WriteLine("Enter to quit");
              




            
           
         




            Console.ReadLine();
        }
    }
}
