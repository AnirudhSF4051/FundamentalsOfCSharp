using System;
namespace ForLoop;
class Program 
{
    public static void Main(string[] args)
    {
        int sum=0,avg=0;
        System.Console.WriteLine("Enter 10 numbers: ");
        for(int i=0;i<10;i++)
        {
            int num=int.Parse(Console.ReadLine());
            sum=sum+num;
            
        }
        avg=sum/10;
        System.Console.WriteLine("Sum: "+sum);
        System.Console.WriteLine("Average: "+avg);
    }
}