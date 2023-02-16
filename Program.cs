/*
 * Author: Madina Giyasova
 * Date: 02/15/2023
 * Description: Deliverable 5  - Methods
 * 
 * 
 */

using System; 

namespace Deliverable_5_Methods;
class Program
{
    static void Main(string[] args)
    {
        int s;


        Console.Write("Enter an integer number between 5 and 15: ");
        string input = Console.ReadLine();

        try
        {
            s = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter an integer number.");
            return;
        }

        if (s < 5 || s > 15)
        {
            Console.WriteLine("Invalid input. The number must be between 5 and 15.");
            return;
        }

        
        int[] array = new int[s];

        
        PopulateArray(array);

        
        Console.Write("All the elements of the array are: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        
        int sum = SumArray(array);

        
        Console.WriteLine("The sum is: " + sum);
    }

    
    static void PopulateArray(int[] array)
    {
        Random ran = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ran.Next(10, 51);
        }
    }

    static int SumArray(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;



    }
}

