
global using System;
/*Problem 01 (MinMaxGenerics)
Напишите обобщенный метод GetMinMax для трех обобщенных параметров, возвращающий минимальное и максимальное значения параметров. Проверьте его работоспособность на типах int, double и string.
static (T min, T max) GetMinMax<T>(T a, T b, T c) where T : IComparable<T> {...}



Problem 02
Напишите обобщенный метод
public static void RearrangeByDesc<T> . . .
"переставляющий" три элемента a, b, c обобщенного типа T в порядке убывания.*/
namespace _0503;
class Program {
  static (T min, T max) GetMinMax<T>(T a, T b, T c) where T : IComparable<T> {
    var items = new List<T> { a, b, c };
    return (items.Min(), items.Max());
  }
  public static void RearrangeByDesc<T>(T a, T b, T c) where T: IComparable<T>{
    var items = new List<T> { a, b, c };
    items.Sort((a, b) => b.CompareTo(a));
    Console.WriteLine($"desc: {items[0]},{items[1]},{items[2]}");
  }

  public static void Demo1() {
    int a = 5;
    int b = 12;
    int c = -1;

    Console.WriteLine($"Min and max: ${GetMinMax(a, b, c)}");
    RearrangeByDesc(a, b, c);
  }

  public static void Main(string[] args) {
    Demo1();
    GenericListDemo.Demo();
  }
}