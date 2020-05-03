using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] firstArray = new int[2] { 2, 2 };
            //int[] secondArray = new int[3] { 1, 2, 3 };
            //int[] thirdArray = new int[3] { 4, 5, 6 };
            //int[] fourthArray = new int[3] { 1, 2, -2 };

            Console.WriteLine("Hello World!");

            //ArrayScoreFinder();

            //LeapYearCalculator();

            //Console.WriteLine(string.Join(", ", firstArray));
            //PerfectSequence(firstArray);

            //Console.WriteLine(string.Join(", ", secondArray));
            //PerfectSequence(secondArray);

            //Console.WriteLine(string.Join(", ", thirdArray));
            //PerfectSequence(thirdArray);

            //Console.WriteLine(string.Join(", ", fourthArray));
            //PerfectSequence(fourthArray);

            SumOfRows();
            SumOfRows();

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

        // Challenge 3

        private static void PerfectSequence(int[] array)
        {
            if (SumOfArray(array) == ProductOfArray(array))
            {
                Console.WriteLine("Yes");
            }
            else if (SumOfArray(array) != ProductOfArray(array))
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var number in array)
                {
                    if (number < 0)
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }

        private static int SumOfArray(int[] array)
        {
            int total = 0;

            foreach (var number in array)
            {
                total += number;
            }
            return total;
        }

        private static int ProductOfArray(int[] array)
        {
            int total = 1;

            foreach (var number in array)
            {
                total *= number;
            }
            return total;
        }

        // Challenge 4

        private static void SumOfRows()
        {
            Console.WriteLine("How many rows are in your matrix?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns are in your matrix?");
            int columns = int.Parse(Console.ReadLine());

            int[,] myMatrix = new int[rows, columns];
            System.Random randomNumber = new System.Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int newNumber = randomNumber.Next(1, 100);
                    myMatrix[i, j] = newNumber;
                }
            }

            int[] outputArray = new int[rows];
            int rowTotal = 0;

            for (int m = 0; m < myMatrix.GetLength(0); m++)
            {
                for (int n = 0; n < myMatrix.GetLength(1); n++)
                {
                    rowTotal += myMatrix[m, n];
                    Console.Write(string.Format("{0} ", myMatrix[m, n]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
                outputArray[m] = rowTotal;
            }
            Console.WriteLine(string.Join(",", outputArray));
        }

    }
}
