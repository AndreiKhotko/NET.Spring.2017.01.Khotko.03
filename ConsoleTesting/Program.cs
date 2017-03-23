using System;
using WorkingWithTypesAndMethods;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingTask1();
            TestingTask2();
            TestingTask3();

            Console.ReadLine();
        }

        private static void TestingTask1()
        {
            Console.WriteLine("===Testing method Task1===");
            int[][] testArrays =
            {
                new int[] { 1, 100, 50, -51, 1, 1 },
                new int[] { 1, 2, 3, 4, 3, 2, 1 }
            };

            foreach (int[] testArray in testArrays)
            {
                int index = Tasks.Task1(testArray);
                Console.Write("Testing array: ");
                foreach (int number in testArray)
                {
                    Console.Write("{0} ", number);
                }
                Console.WriteLine();
                Console.WriteLine("index = {0}", index);
            }

            Console.WriteLine("===End testing method Task1===");

            Console.WriteLine();
        }

        private static void TestingTask2()
        {
            Console.WriteLine("===Testing method Task2===");

            string[][] stringSet = new string[][]
            {
                new string[2]
                {
                    "xyaabbbccccdefww",
                    "xxxxyyyyabklmopq"
                },

                new string[2]
                {
                    "abcdefghijklmnopqrstuvwxyz",
                    "abcdefghijklmnopqrstuvwxyz"
                }

            }; 

            foreach (string[] strings in stringSet)
            {
                Console.WriteLine("Strings: {0}, {1}", strings[0], strings[1]);

                string result = Tasks.Task2(strings[0], strings[1]);

                Console.WriteLine("Result: {0}", result);
            }
            
            Console.WriteLine("===End testing method Task2===");

            Console.WriteLine();
        }

        private static void TestingTask3()
        {
            Console.WriteLine("===Testing method Task3===");

            int[][] TestParameters = new int[][]
            {
                new int[4] {8, 15, 0, 0},
                new int[4] {0, 15, 30, 30},
                new int[4] {0, 15, 0, 30},
                new int[4] {15, -15, 0, 4},
                new int[4] {15, int.MaxValue, 3, 5},
                new int[4] {int.MaxValue, int.MaxValue, 3, 5},
                new int[4] {15, 15, 1, 3 },
                new int[4] {15, 15, 1, 4},
                new int[4] {15, -15, 1, 4 },
                new int[4] {-8, -15, 1, 4 }
            };
            
            foreach (int[] parameters in TestParameters)
                Console.WriteLine("Result of Task3({0}, {1}, {2}, {3}): {4}", parameters[0], parameters[1], parameters[2], parameters[3], 
                    Tasks.Task3(parameters[0], parameters[1], parameters[2], parameters[3]));

            Console.WriteLine("===End testing method Task3===");
        }
    }
}
