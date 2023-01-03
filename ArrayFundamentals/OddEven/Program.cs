using System;
namespace OddEven;
class Program 
{
    public static void Main(string[] args)
    {
        int min,temp;
        int[]array=new int[10];
        System.Console.WriteLine("Enter Array Elemets: ");
        for(int i=0;i<=array.Length-1;i++)
        {
            array[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("The Even Elements are");
        for(int j=0;j<=array.Length-1;j++)
        {
            if(array[j]%2==0)
            {
                
                System.Console.WriteLine(array[j]);
            }
        }
        System.Console.WriteLine("The Odd Elements are");
        for(int k=0;k<=array.Length-1;k++)
        {
            if(array[k]%2!=0)
            {
                System.Console.WriteLine(array[k]);
            }
        }
        


    }
}