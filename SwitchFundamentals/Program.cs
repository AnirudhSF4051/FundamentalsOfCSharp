using System;
namespace SwitchFundamentals;
class Program
{
    public static void Main(string[] args)
    {
        string choice = "";

        int result;
        System.Console.WriteLine("Enter Number 1:");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Number 2:");
        int number2 = int.Parse(Console.ReadLine());
        do
        {
            System.Console.WriteLine("\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            System.Console.WriteLine("Enter your choice from 1-4");
            int choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    {
                        result = number1 + number2;
                        System.Console.WriteLine("The sum is: " + result);
                        break;
                    }
                case 2:
                    {
                        result = number1 - number2;
                        System.Console.WriteLine("The difference is: " + result);
                        break;
                    }
                case 3:
                    {
                        result = number1 * number2;
                        System.Console.WriteLine("The product is: " + result);
                        break;
                    }
                case 4:
                    {
                        result = number1 / number2;
                        System.Console.WriteLine("The quotient is: " + result);
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Enter Valid Number");
                        break;
                    }
            }
            System.Console.WriteLine("Do you want to Continue?\nsay yes/no");
            choice = Console.ReadLine().ToLower();

        } while (choice == "yes");

    }
}
