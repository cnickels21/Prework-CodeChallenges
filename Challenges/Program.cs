using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ArrayScoreFinder();
            LeapYearCalculator();
            LeapYearCalculator();
            LeapYearCalculator();
            LeapYearCalculator();
            Console.ReadLine();
        }

        // Challenge 1
        private static void ArrayScoreFinder()
        {
            int[] userArray = new int[5];
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter a number between 1-10.");
                int currentAnswer = int.Parse(Console.ReadLine());

                if (currentAnswer > 10 || currentAnswer < 1)
                {
                    Console.WriteLine("That is not between 1-10. Try again.");
                    i--;
                }
                else
                {
                    userArray[i] = currentAnswer;
                }
            }

            Console.WriteLine(string.Join(", ", userArray));
            Console.WriteLine("Select a number from the array.");

            int userAnswer = int.Parse(Console.ReadLine());
            int counter = 0;

            foreach (int number in userArray)
            {
                if (userAnswer == number)
                {
                    counter++;
                }
            }

            Console.WriteLine(userAnswer * counter);

        }

        // Challenge 2
        private static void LeapYearCalculator()
        {
            Console.WriteLine("Enter a year (ie. 1991).");
            int userYear = int.Parse(Console.ReadLine());

            if (userYear % 4 == 0)
            {
                if (userYear % 100 == 0)
                {
                    if (userYear % 400 == 0)
                    {
                        Console.WriteLine("That is a leap year!");
                    }
                    else
                    {
                        Console.WriteLine("That is not a leap year.");
                    }

                }
                else
                {
                    Console.WriteLine("That is a leap year!");
                }
            }
            else
            {
                Console.WriteLine("That is not a leap year!");
            }
        }


    }
}
