using System;
namespace CSharpFundamentalsOperators2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number 1:");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter number 2:");
        int number2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter number 3:");
        int number3=int.Parse(Console.ReadLine());

        if(number1>number2&&number1>number3)
        {
            System.Console.WriteLine($"{number1} is the greatest");
        }
        else if(number2>number3)
        {
            System.Console.WriteLine($"{number2} is the greatest");
        }
        else 
        {
            System.Console.WriteLine($"{number3} is the greatest");
        }
    }
}
