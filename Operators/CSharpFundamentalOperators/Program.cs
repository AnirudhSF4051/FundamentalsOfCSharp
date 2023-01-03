using System;
namespace CSharpFundamentalOperators;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Number 1: ");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Number 2: ");
        int number2=int.Parse(Console.ReadLine());
        int add=number1+number2;
        System.Console.WriteLine("Sum: "+add);
        int sub=number1-number2;
        System.Console.WriteLine("Difference: "+sub);
        int product=number1*number2;
        System.Console.WriteLine("Product: "+product);
        float div=(float)number1/number2;
        System.Console.WriteLine("Quotient: "+div);
        int mod=number1%number2;
        System.Console.WriteLine("Remainder: "+mod);
    }
}