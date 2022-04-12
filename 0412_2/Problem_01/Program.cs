// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

public class Problem_01
{
  public static int[] GetIntArray(int size, int min = 0, int max = int.MaxValue)
  {
    int[] arr = new int[size];
    var rnd = new Random(0);
    for(int i =0; i < size; i++)
    {
      arr[i] = rnd.Next(min, max);
    }
    return arr;
  }
  public static double[] GetDoubleArray(int size)
  {
    var rnd = new Random();
    var arr = new double[size];
    for (int i = 0; i < size; i++)
    {
      arr[i] = rnd.NextDouble();
    }
    return arr;
  }



  static void Main(string[] args)
  {
   
    int size = 12;
    int[] arr1 = GetIntArray(size,-10,10);
    for(int i =0; i<arr1.Length; i++)
    {
      Write($"{arr1[i],4}");
    }

  }
}