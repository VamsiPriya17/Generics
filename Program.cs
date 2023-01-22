// See https://aka.ms/new-console-template for more information
using System;

class MaxEle
{
    public static T maximum<T>(T[] arr)
    {
        T max = arr[0];

        foreach(T ele in arr)
        {
            if(Comparer<T>.Default.Compare(max, ele) > 0)
                max = ele;
        }

        return max;
    } 

    public static void Main()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 6, 5 };
        int[] arr3 = { 9, 7, 8 };

        float[] arr4 = { 134.45E-2f, 134.45E+2f, 134.45E-4f };
        float[] arr5 = { 134.45E+2f, 134.45E-2f, 134.45E-4f };
        float[] arr6 = { 134.45E-2f, 134.45E+2f, 134.45E-4f };

        string[] arr7 = { "apple", "mango", "bananas" };
        string[] arr8 = { "apple", "bananas", "mango" };
        string[] arr9 = { "bananas", "apple", "mango" };

        Console.WriteLine("Maximum is " + maximum(arr1));
        Console.WriteLine("Maximum is " + maximum(arr2));
        Console.WriteLine("Maximum is " + maximum(arr3));
        Console.WriteLine("******************************");

        Console.WriteLine("Maximum is " + maximum(arr4));
        Console.WriteLine("Maximum is " + maximum(arr5));
        Console.WriteLine("Maximum is " + maximum(arr6));
        Console.WriteLine("******************************");

        Console.WriteLine("Maximum is " + maximum(arr7));
        Console.WriteLine("Maximum is " + maximum(arr8));
        Console.WriteLine("Maximum is " + maximum(arr9));
    }
}
