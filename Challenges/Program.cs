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

        private static void ArrayScoreFinder()
        {
            int[] userArray = new int[5];
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter a number between 1-10.");
                userArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", userArray));
        }

    }
}
