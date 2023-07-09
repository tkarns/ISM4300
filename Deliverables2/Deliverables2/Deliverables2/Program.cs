using System;

namespace Deliverables2
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }
        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15:");
                int input = int.Parse(Console.ReadLine());

                if (input >= 5 && input <= 15)
                {
                    int[] MyArray = random_array(input);
                    Console.Write("The elements in the random array are: ");
                    foreach (int i in MyArray)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("The sum is: " + sum(MyArray));
                }
                else
                {
                    Console.WriteLine("Invalid input. The number should be between 5 and 15.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }





        }
    }
}




