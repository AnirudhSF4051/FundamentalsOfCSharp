using System;
namespace StringProgram2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a string: ");
        string sentence=Console.ReadLine();
        string[]word=sentence.Split(",");
        foreach(var words in word)
        {
            System.Console.WriteLine($"{words}");
        }
    }
}