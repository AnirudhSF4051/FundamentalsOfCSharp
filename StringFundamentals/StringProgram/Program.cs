using System;
namespace StringProgram;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a word: ");
        string word=Console.ReadLine();
        System.Console.WriteLine("The length of the word is: "+word.Length);
        if(word.Contains("n"))
        {
           string word1= word.Replace("n","N");
            System.Console.WriteLine(word1);    
        }
        for(int j=word.Length-1;j>=0;j--)
        {
            System.Console.WriteLine(word[j]);
        }

        string word2="Computer";
        string word3="Science";

        word2=word2.Remove(5);
        word3=word3.Remove(0,3);
        System.Console.WriteLine(word2+word3);
        
    }
}
