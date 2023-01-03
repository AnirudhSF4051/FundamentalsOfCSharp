using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqFundamentals2;
class Program
{
    public static void Main(string[] args)
    {
        
        string[]city = new string[8];
        System.Console.WriteLine("Enter the cities: ");
        for (int i = 0; i <= city.Length - 1; i++)
        {
            city[i] = Console.ReadLine().ToUpper();

        }
        System.Console.WriteLine("Sorted Order");
        IEnumerable<string> cityOrder=city.OrderBy(str=>str.Length).ThenBy(str=>str);
        foreach(string cities in cityOrder)
        {
            System.Console.WriteLine(cities);
        }
        
    }
}
