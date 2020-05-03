using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayScoreFinder();
            Console.ReadLine();
        }

        // Challenge 1
        private static void ArrayScoreFinder()
        {
            int[] userArray = new int[5];
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter a number between 1-10.");
                userArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(", ", userArray));
            Console.WriteLine("Select a number from the array.");

            int userAnswer = int.Parse(Console.ReadLine());
            int counter = 0;
            
            foreach(int number in userArray)
            {
                if(userAnswer == number)
                {
                    counter++;
                }
            }

            Console.WriteLine(userAnswer * counter);
            
        }

        // Challenge 2

    }
}
