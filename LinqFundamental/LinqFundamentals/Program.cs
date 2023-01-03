using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqFundamentals;
class Program
{
    public static void Main(string[] args)
    {
        string choice = "";
        string[] city = new string[8];
        System.Console.WriteLine("Enter the cities: ");
        for (int i = 0; i <= city.Length - 1; i++)
        {
            city[i] = Console.ReadLine().ToUpper();

        }
        do
        {
            System.Console.WriteLine("Enter Starting Word: ");
            string start = Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter Ending Word");
            string end = Console.ReadLine().ToUpper();
            bool check = true;
            for (int j = 0; j <= city.Length - 1; j++)
            {
                if (city[j].StartsWith(start) && city[j].EndsWith(end))
                {
                    check = false;
                    System.Console.WriteLine($"The city starting with {start} and ending with {end} is: {city[j]}");
                }

            }
            if (check)
            {
                System.Console.WriteLine($"There is no city starting with {start} and ending with {end}");
            }

            System.Console.WriteLine("If you want to continue, type yes");
            choice=Console.ReadLine().ToLower();
            

        } while (choice == "yes");

    }
}