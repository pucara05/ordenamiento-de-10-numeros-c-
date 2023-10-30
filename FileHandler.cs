using System;
using System.IO;

public static class FileHandler
{
    public static void SaveToFile(long[] numbers)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("sorted_numbers.txt"))
            {
                foreach (long num in numbers)
                {
                    writer.WriteLine(num);
                }
            }
            Console.WriteLine("Numbers saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }
}