using System;
using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by spaces: ");
            string[] input = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine($"The average is: {CalculateAverage(input)}");
            Console.WriteLine($"All numbers: {string.Join(", ", input)}");
            Console.WriteLine($"Zeros Count: {CountZeros(input)}");
            Console.WriteLine($"The closest number to average: {ClosestNumberToAverage(input)}");
            PrintAllElements(input);
        }

        static void PrintAllElements(string[] input)
        {
            Console.WriteLine("All elemetns with their index:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Number: {input[i]} - Index: {i}");
            }
        }

        static int ClosestNumberToAverage(string[] input)
        {
            double average = CalculateAverage(input);
            int[] numbers = Array.ConvertAll(input, int.Parse);
            int closest = numbers[0];
            int index = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i] - average) < Math.Abs(closest - average))
                {
                    closest = numbers[i];
                    index = i;
                }
            }

            return closest;
        }

        static int CountZeros(string[] input)
        {
            int count = 0;
            int[] numbers = Array.ConvertAll(input, int.Parse);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static double CalculateAverage(string[] input)
        {
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += double.Parse(input[i]);
            }
            return sum / input.Length;
        }
    }