// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Demo_0412 {
  class Program
  {

    //  Problem 00
    //Напишите методы, возвращающие:
    //public static double GetMax(double[] arr)
    //public static double GetMin(double[] arr)
    //public static double GetSum(double[] arr)
    //public static double GetAverage(double[] arr)

    //public static bool Contains(int[] arr, int item) (содержит ли заданный item)

    //Продемонстрируйте их работу на массивах, создаваемых, в частности, с помощью методов из Problem 01.

    static double[] GenerateDoubleArr(int size)
    {
      var rnd = new Random();
      var arr = new double[size];
      for (int i = 0; i < size; i++)
      {
        arr[i] = rnd.NextDouble();
      }
      return arr;
    }

    public static double GetMax(double[] arr)
    {
      return arr.Max();
    }
    public static double GetMin(double[] arr)
    {
      return arr.Min();
    }
    public static double GetSum(double[] arr)
    {
      return arr.Sum();
    }
    public static double GetAverage(double[] arr)
    {
      return arr.Average();
    }
    public static bool Contains(int[] arr, int item)
    {
      return arr.Contains(item);
    }
    //    Problem 00
    //Напишите методы для печати одномерного массива в одну строку:
    //public static void PrintArray(int[] arr)
    //public static void PrintArray(double[] arr)
    //Если размер массива превышает 8, то выводите только 4 первые и 4 последние элемента с многоточием посередине:
    //16,04   255,14     6,55   706,84  . . . . . . . .      6,88  8964,22     7,99    55,60
    //
    public static void PrintArray(double[] arr)
    {
      if (arr.Length <= 8)
      {
        for(int i=0; i<arr.Length; i++)
        {
          Write($"{arr[i],5}");
        }
      }
      else
      {
        for (int i = 0; i < 4; i++)
        {
          Write($"{arr[i],5}");
        }
        Write(" . . . . .");
        for(int i = arr.Length-4; i<arr.Length; i++)
        {
          Write($"{arr[i],5}");
        }
      }
    }
    public static void PrintArray(int[] arr)
    {
      if (arr.Length <= 8)
      {
        for (int i = 0; i < arr.Length; i++)
        {
          Write($"{arr[i],5}");
        }
      }
      else
      {
        for (int i = 0; i < 4; i++)
        {
          Write($"{arr[i],5}");
        }
        Write(" . . . . .");
        for (int i = arr.Length - 4; i < arr.Length; i++)
        {
          Write($"{arr[i],5}");
        }
      }
    }

    public static void Main(string[] args)
    {
      try
      {
        int size = 10;
        double[] arr1 = GenerateDoubleArr(size);
        WriteLine($"Max: {GetMax(arr1)}");
        WriteLine($"Min: {GetMin(arr1)}");
        WriteLine($"Sum: {GetSum(arr1)}");
        WriteLine($"Average: {GetAverage(arr1)}");

        int[] arr2 = { 1, 2, 3, 4, 5, 6 };
        WriteLine($"arr2 contains 6: {Contains(arr2, 6)}");
        WriteLine($"arr2 contains 10: {Contains(arr2, 10)}");

        double[] arr3 = { 5.4, 0.5, 4.1, 9.9 };
        double[] arr4 = { 1.2, 3.5, 0.2, 4.3, 8.6, 1.1, 12.2, 3.3, 0.9, 6.7 };
        WriteLine("\ndouble print");
        PrintArray(arr3);
        WriteLine("");
        PrintArray(arr4);
        WriteLine("\nint print");
        int[] arr5 = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] arr6 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        PrintArray(arr5);
        WriteLine("");
        PrintArray(arr6);
        WriteLine("\n");
      }
      catch (Exception e) {
        WriteLine(e);
      }

    }
  }
}