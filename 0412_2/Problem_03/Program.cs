// See https://aka.ms/new-console-template for more information

//Problem 00
//public struct PointStruct { public int X; public int Y; }
//public class PointClass { public int X; public int Y; }
//Напишите метод,
//public static void DoWithStruct(PointStruct point, int n)
//принимающий переменную типа PointStruct и целое число n. Увеличьте внутри функции значения X и Y на величину n.
//Выведите значения X и Y до вызова функции и после возвращения.

//Проведите  аналогичные действия с PointClass:
//public static void DoWithClass(PointClass point, int n)
//Объясните результаты.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class Problem_03
{
  public struct PointStruct { public int X; public int Y; }
  public class PointClass { public int X; public int Y; }

  public static void DoWithStruct(PointStruct point, int n)
  {
    WriteLine($"Original point struct coordinates: ({point.X}, {point.Y})");
    point.X += n;
    point.Y += n;
    WriteLine($"Point struct coordinates increased by n-{n}:  ({point.X}, {point.Y})");
  }
  public static void DoWithClass(PointClass point, int n)
  {
    WriteLine($"Original point class coordinates: ({point.X}, {point.Y})");
    point.X += n;
    point.Y += n;
    WriteLine($"Point class coordinates increased by n-{n}:  ({point.X}, {point.Y})");
  }


  static void Main(string[] args)
  {
    PointStruct p1 = new PointStruct();
    p1.X = 5; p1.Y = 3;
    int n1 = 10;
    DoWithStruct(p1,n1);
    WriteLine("\n");
    PointClass p2 = new PointClass();
    p2.X = 5; p2.Y = 3;
    int n2 = 4;
    DoWithClass(p2, n2);

  }
}