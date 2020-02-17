using System;
using System.Linq;


namespace Hactiv8Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Second Great Low");
            int[] testSecondGreatLow = { 7, 7, 12, 98, 106 };
            SecondGreatLow(testSecondGreatLow);
            Console.ReadKey();

            Console.WriteLine("Testing Multiplicative Persistence");
            Console.WriteLine("Result of this test is :" + MultiplicativePersistence(39));
            Console.ReadKey();

            Console.WriteLine("Testing Mean Mode");
            int[] Numbers = { 5, 3, 3, 3, 1 };
            Console.WriteLine("Result of this test is :" + MeanMode(Numbers));
            Console.ReadKey();

        }

        /// <summary>
        /// Second Great Low
        /// Function that take the array of numbers and return the second lowest and second greatest number
        /// </summary>
        /// <param name="input">array of integer</param>
        static void SecondGreatLow(int[] input)
        {
            int size = input.Count();
            if (size < 2)
            {
                Console.WriteLine("Ukuran Array harus lebih besar dari 2");
            }
            else
            {
                int[] sortedArray = input.Distinct().ToArray<int>();
                Array.Sort<int>(sortedArray);
                //Console.WriteLine("Second Lowest : {0}", sortedArray[1]);
                size = sortedArray.Count();
                Console.WriteLine("{0} {1}", sortedArray[1], sortedArray[size-2]);
            }
        }

        /// <summary>
        /// Multiplicative Persistence with Recursive
        /// Function that take integer which will always return positive integer for its multiplicative persistence
        /// which is the number of times that multiplied the digit until reach a single digit
        /// </summary>
        /// <param name="number">Positive Integer</param>
        /// <returns></returns>
        static int MultiplicativePersistence(int number)
        {
            if(number < 10)
            {
                return number;
            }
            else
            {
                int firstDigit = number % 10;
                int secodDigit = (number - firstDigit)/10;
                int multiply = firstDigit * secodDigit;
                return MultiplicativePersistence(multiply);
            }
        }

        /// <summary>
        /// Mean Mode
        /// Function that return 1 if the mode equals the mean
        /// And return 0 if they dont equal each other
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static int MeanMode(int[] input)
        {
            int initInput = input.Count();
            int checkedInput = input.Distinct<int>().Count();

            if (initInput != checkedInput)
                return 1;
            else
                return 0;
        }
    }
}
