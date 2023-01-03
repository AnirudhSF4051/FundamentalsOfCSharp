using System;
namespace Sorting;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter total number of elements in array: ");
        
        int[]arr=new int[5];
        for(int i=0;i<arr.Length;i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        int temp,min;
        for(int j=0;j<arr.Length-1;j++)
        {
            min=j;
            for(int k=j+1;k<arr.Length;k++)
            {
                if(arr[k]<arr[min])
                {
                    min=k;
                }
            }
            temp=arr[min];
            arr[min]=arr[j];
            arr[j]=temp;
        }
        System.Console.WriteLine("Sorted Array");
        for(int l=0;l<arr.Length;l++)
        {
            System.Console.WriteLine(arr[l]);
        }
    }
}
