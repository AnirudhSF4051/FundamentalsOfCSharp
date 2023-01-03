using System;
namespace ExceptionalHandlingFundamentals;
class Program 
{
    public static void Main(string[] args)
    {
        try 
        {
            System.Console.WriteLine("Enter number 1: ");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number 2: ");
            int number2=int.Parse(Console.ReadLine());
            int result=number1/number2;
            System.Console.WriteLine(result);
        }
        catch(Exception e) 
        {
            System.Console.WriteLine(e.Message);
        }
    }
}