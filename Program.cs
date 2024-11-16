// See https://aka.ms/new-console-template for more information
using System;

// Name: Rami Issa
// University ID: 202411152

class Program
{
    static void Main(string[] args)
    {
        try
        {
           
            Console.Write("Enter minNumber: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter maxNumber: ");
            int maxNumber = int.Parse(Console.ReadLine());

            
            if (minNumber > maxNumber)
            {
                Console.WriteLine("Error: minNumber should be less than or equal to maxNumber.");
                return;
            }

            
            int range = maxNumber - minNumber + 1;
            int[] frequency = new int[range];

            
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int randomNumber = random.Next(minNumber, maxNumber + 1);
                frequency[randomNumber - minNumber]++;
            }

            
            Console.WriteLine("\nNumber\tFrequency");
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine($"{minNumber + i}\t{frequency[i]}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integers.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Array index out of bounds.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
