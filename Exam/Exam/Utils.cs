using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Exam;
public static class Utils {

  public static int[] GetIntArray(int size, int min = 0, int max = int.MaxValue) {
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++) {
      arr[i] = rnd.Next(min, max);
    }
    return arr;
  }

  public static int[,] GetIntMatrix(int length, int width, int min = 0, int max = int.MaxValue) {
    int[,] mat = new int[length, width];
    var rnd = new Random();
    for (int i = 0; i < length; i++) {
      for (int j = 0; j < width; j++) {
        mat[i, j] = rnd.Next(min, max);
      }
    }
    return mat;
  }

  public static double[] GetDoubleArray(int size, double min = 0, double max = double.MaxValue) {
    double[] arr = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++) {
      arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
  }

  public static double[,] GetDoubleMatrix(int length, int width, double min = 0, double max = double.MaxValue) {
    double[,] mat = new double[length, width];
    var rnd = new Random();
    for (int i = 0; i < length; i++) {
      for (int j = 0; j < width; j++) {
        mat[i, j] = rnd.NextDouble() * (max - min) + min;
      }
    }
    return mat;
  }



  public static void PrintArray<T>(T[] arr, int width = 8, int decimals = 0, bool printAll=false) {
    string format = "{0," + width.ToString() + "}";
    format = "{0," + width.ToString() + "}";
    if (typeof(T) == typeof(double))
      format = "{0," + width.ToString() + ":N" + decimals.ToString() + "}";

    int size = arr.Length;
    if (size <= 8|| printAll) {
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

  public static void PrintMatrix<T>(T[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
      for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write($"{matrix[i, j],6:F1}");
      }
      Console.WriteLine();
    }
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




  public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0, bool printAll = false) {
    PrintArray<T>(list.ToArray(), width, decimals,printAll);
  }



  public static void PrintListByLines<T>(List<T> list, bool printAll = false) {
    int size = list.Count;
    if (size <= 8 || printAll) {
      for (int i = 0; i < size; i++) {
        WriteLine(list[i]);
      }
    } else {
      for (int i = 0; i < 4; i++) {
        WriteLine(list[i]);
      }
      WriteLine(". . . . . . . . . . . . ");
      for (int i = size - 4; i < size; i++) {
        WriteLine(list[i]);
      }
    }
    WriteLine();
  }
}