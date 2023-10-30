using System;

public class Program
{   
    static void Main()
    {
         long[] numbers = new long[10];

        try
        {
            Console.WriteLine("Please enter 10 different numbers separated by spaces:");

            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');

            if (inputNumbers.Length != 10)
            {
                throw new Exception("You must enter exactly 10 numbers.");
            }

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = long.Parse(inputNumbers[i]);
            }

            SortingAlgorithms.BubbleSort(numbers);

            Console.WriteLine("\nSorted Numbers:");
            foreach (long num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.Write("\nDo you want to save the sorted numbers to a file? (yes/no): ");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                FileHandler.SaveToFile(numbers);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}