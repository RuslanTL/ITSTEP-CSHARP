// See https://aka.ms/new-console-template for more information
//public static void Reverse(double[] arr)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
class Problem_02
{
  public static double[] GetDoubleArray(int size)
  {
    var rnd = new Random();
    var arr = new double[size];
    for (int i = 0; i < size; i++)
    {
      arr[i] = Math.Round(rnd.NextDouble(),1);
    }
    return arr;
  }
  public static void PrintArray(double[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
      Write($"{arr[i],5}");
    }
  }
  public static void Reverse(double[] arr)
  {
    for(int i =0, j=arr.Length-1; i< arr.Length/2; i++, j--)
    {
      var temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
    }
  }

  static void Main(string[] args)
  {
    double[] arr1 = GetDoubleArray(10);
    PrintArray(arr1);
    Reverse(arr1);
    WriteLine("\n Reversed: ");
    PrintArray(arr1);

  }
}