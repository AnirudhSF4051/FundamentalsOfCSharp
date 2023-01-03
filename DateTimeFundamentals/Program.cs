using System;
namespace DateTimeFundamentals;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2023,01,01);
        System.Console.WriteLine(date.Month);
        DateTime date1=date.AddDays(-3);
        System.Console.WriteLine(date1.ToString("dd/MM/yyyy"));
        System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss:tt"));
    }
}