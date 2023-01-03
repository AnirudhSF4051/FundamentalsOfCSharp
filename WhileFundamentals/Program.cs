using System;
namespace WhileFundamentals;
class Program
{
    public static void Main(string[] args)
    {
        string choice1="";
        do
        {
            System.Console.WriteLine("Which city is capital of India?");
            System.Console.WriteLine("\n1.Chennai\n2.Delhi\n3.Mumbai\n4.Kolkata");
            System.Console.WriteLine("Enter your choice from 1-4");
            int choice = int.Parse(Console.ReadLine());
            


            while (choice >= 1 && choice <= 4)
            {
                if (choice == 2)
                {
                    System.Console.WriteLine("Correct");
                }
                else
                {
                    System.Console.WriteLine("Incorrect");
                }
                break;

            }
            System.Console.WriteLine("Do you want to Continue?\nsay Y?N");
            choice1 = Console.ReadLine().ToUpper();

        }while(choice1=="Y");
    }
}