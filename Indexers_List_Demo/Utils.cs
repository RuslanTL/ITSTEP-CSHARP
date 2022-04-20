using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace UtilsNS {
  public static class Utils {

    public static int[] GetIntArray(int size, int min = 0, int max = int.MaxValue) {
      int[] arr = new int[size];
      var rnd = new Random(0);
      for (int i = 0; i < size; i++) {
        arr[i] = rnd.Next(min, max);
      }
      return arr;
    }

        /*
    Problem 02
    По подобию метода GetIntArray в Utils, напишите метод 
    public static List<int> GetIntList(int size, int min = 0, int max = int.MaxValue),
    возвращающий List случайных чисел.*/  

    public static List<int> GetIntList(int size, int min=0, int max = int.MaxValue) {
      var newList = new List<int>();
      var rnd = new Random(0);
      for(int i=0; i<size; i++) {
        newList.Add(rnd.Next(min, max));
      }
      return newList;
    }

        /*Problem 03
    Напишите метод
    public static List<int> GetSomeEvensList(int max),
    возвращающий все положительные целые четные числа меньше max, не делящиеся на 5.
    */
    
    public static List<int> GetSomeEvensList(int max) {
      var newList = new List<int>();
      for(int i=0; i < max; i++) {
        if(i%2==0 && i % 5 != 0) {
          newList.Add(i);
        }
      }
      return newList;
    }

    /*

    Problem 04 - GetOddEvenArrays
    Напишите метод, возвращающий кортеж из массивов нечетных и четных чисел, извлекаемых из переданного массива целых чисел:
    public static (int[] oddArr, int[] evenArr) GetOddEvenArrays(int[] arr).
    Для создания массива используйте Utils.GetIntArray, для распечатки - Utils.PrintArray(arrOdd); Utils.PrintArray(arrEven);
    Выполните проверку:
    WriteLine($"oddArr.Length + evenArr.Length == arr.Length: {oddArr.Length + evenArr.Length == arr.Length}");
    */

    public static (int[] oddArr, int[] evenArr) GetOddEvenArrays(int[] arr) {
      var odd = new List<int>();
      var even = new List<int>();

      for (int i=0; i < arr.Length; i++) {
        if (i % 2 == 0) {
          even.Add(arr[i]);
        } else if (i % 2 != 0) {
          odd.Add(arr[i]);
        }
      }
      var oddArr = odd.ToArray();
      var evenArr = even.ToArray();

      WriteLine("Even: \n");
      PrintArray(evenArr);
      WriteLine("Odd: \n");
      PrintArray(oddArr);

      WriteLine($"oddArr.Length + evenArr.Length == arr.Length: {oddArr.Length + evenArr.Length == arr.Length}");
      return (oddArr, evenArr);
    }

        /*
    Problem 05 - GetOddEvenLists
    Решите предыдущую задачу, используя List<int>.
    public static (List<int> oddList, List<int> evenList) GetOddEvenLists(int[] arr) 

    Реализуйте метод распечатки
    public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0)
    по подобию PrintArray<T>, или воспользуйтесь кодом:
    public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0) {
	    PrintArray<T>(list.ToArray(), width, decimals);
    }
    */
    public static (List<int> oddList, List<int> evenList) GetOddEvenLists(int[] arr) {
      var odd = new List<int>();
      var even = new List<int>();

      for (int i = 0; i < arr.Length; i++) {
        if (i % 2 == 0) {
          even.Add(arr[i]);
        } else if (i % 2 != 0) {
          odd.Add(arr[i]);
        }
      }


      WriteLine("Even: \n");
      PrintList(even);
      WriteLine("Odd: \n");
      PrintList(odd);

      WriteLine($"oddArr.Length + evenArr.Length == arr.Length: {odd.Count + even.Count == arr.Length}");
      return (odd, even);
    }

        /*

    Problem 06
    Напишите метод, возвращающий кортеж из двух List<int> - чисел до первого вхождения числа splitter включительно и остальных.
    public static (List<int> firstList, List<int> secondList) GetSomeLists(int[] arr, int splitter).
    */
    public static (List<int> firstList, List<int> secondList) GetSomeLists(int[] arr, int splitter) {

      var first = new List<int>();
      var second = new List<int>();
      for(int i = 0; i < arr.Length; i++) {
        if (i <= splitter) {
          first.Add(arr[i]);
        } else {
          second.Add(arr[i]);
        }
      }


      WriteLine("first: \n");
      PrintList(first);
      WriteLine("second: \n");
      PrintList(second);

      return (first, second);
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


    public static void PrintArrayByLines<T>(T[] arr) {
      int size = arr.Length;
      if (size <= 8) {
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

  }
}
