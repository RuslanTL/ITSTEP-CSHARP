using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace _0505;
public static class Utils {

  public static int[] GetIntArray(int size, int min = 0, int max = int.MaxValue) {
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++) {
      arr[i] = rnd.Next(min, max);
    }
    return arr;
  }

  public static double[] GetDoubleArray(int size, double min = 0, double max = double.MaxValue) {
    double[] arr = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++) {
      arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
  }



  public static void PrintArray<T>(T[] arr, int width = 8, int decimals = 0) {
    string format = "{0," + width.ToString() + "}";
    format = "{0," + width.ToString() + "}";
    if (typeof(T) == typeof(double))
      format = "{0," + width.ToString() + ":N" + decimals.ToString() + "}";

    int size = arr.Length;
    if (size <= 8) {
      for (int i = 0; i < size; i++) {
        Write(format, arr[i]);
      }
    } else {
      for (int i = 0; i < 4; i++) {
        Write(format, arr[i]);
      }
      Write(" . . . . . ");
      for (int i = size - 4; i < size; i++) {
        Write(format, arr[i]);
      }
    }
    WriteLine();
  }
  public static void PrintDictionary<TKey,TValue>(Dictionary<TKey,TValue> dict, int width = 8, int decimals = 0) {
    string format = "{0," + width.ToString() + "}";
    format = "{0," + width.ToString() + "}";
    if (typeof(TValue) == typeof(double))
      format = "{0," + width.ToString() + ":N" + decimals.ToString() + "}";

    int size = dict.Count();
    int cnt = 0;
    foreach (KeyValuePair<TKey, TValue> item in dict) {
      if (cnt < 8 || cnt < dict.Count) {
        WriteLine("{0,12}", $"key: {item.Key} | value: {item.Value}");
        cnt++;
      }
      if (cnt == 8) {
        WriteLine("------------------------------------------");
        cnt = dict.Count - 8;
      }
      
    }
    WriteLine();
  }


  public static void PrintArrayByLines<T>(T[] arr, bool printAll = false) {
    int size = arr.Length;
    if (size <= 8 || printAll) {
      for (int i = 0; i < size; i++) {
        WriteLine(arr[i]);
      }
    } else {
      for (int i = 0; i < 4; i++) {
        WriteLine(arr[i]);
      }
      WriteLine(". . . . . . . . . . . . ");
      for (int i = size - 4; i < size; i++) {
        WriteLine(arr[i]);
      }
    }
    WriteLine();
  }




  public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0) {
    PrintArray<T>(list.ToArray(), width, decimals);
  }



  public static void PrintListByLines<T>(List<T> list, bool printAll = false) {
    int size = list.Count;
    if (size <= 8 || printAll) {
      for (int i = 0; i < size; i++) {
        WriteLine(list[i]);
      }
    } else {
      for (int i = 0; i < 8; i++) {
        WriteLine(list[i]);
      }
      WriteLine(". . . . . . . . . . . . ");
      for (int i = size - 8; i < size; i++) {
        WriteLine(list[i]);
      }
    }
    WriteLine();
  }
  public static void PrintListPairs<TKey, TValue>(List<KeyValuePair<TKey,TValue>> list, bool printAll = false) {
    int size = list.Count;
    if (size <= 8 || printAll) {
      for (int i = 0; i < size; i++) {
        WriteLine($"{list[i].Key,12} | {list[i].Value} ");
      }
    } else {
      for (int i = 0; i < 8; i++) {
        WriteLine($"{list[i].Key,12} | {list[i].Value} ");
      }
      WriteLine(". . . . . . . . . . . . ");
      for (int i = size - 8; i < size; i++) {
        WriteLine($"{list[i].Key,12} | {list[i].Value} ");
      }
    }
    WriteLine();
  }
}