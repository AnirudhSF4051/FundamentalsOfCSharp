using System;
namespace IfProgram;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a alphabet from A-D: ");
        string grade=Console.ReadLine().ToUpper();
        if(grade=="A")
        {
            System.Console.WriteLine("Grade A denotes 9 points");
        }
         else if(grade=="B")
        {
            System.Console.WriteLine("Grade B denotes 8 points");
        }
         else if(grade=="C")
        {
            System.Console.WriteLine("Grade C denotes 7 points");
        }
         else if(grade=="D")
        {
            System.Console.WriteLine("Grade D denotes 6 points");
        }
        else 
        {
            System.Console.WriteLine("Invalid Grade");
        }
        
    }
}