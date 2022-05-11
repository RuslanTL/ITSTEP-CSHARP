using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
/*Problem 04
Напишите метод 
public static int[] GetUniqueRandomArray(int size, int min = 0, int max = int.MaxValue)
возвращающий случайный массив НЕПОВТОРЯЮЩИХСЯ целых чисел в заданном интервале. Все числа из интервала [min, max] должны иметь равную вероятность появления в итоговом массиве.

Обеспечьте максимально быструю скорость формирования массива!

Возвращаемый массив проверяйте на уникальность чисел с помощью метода
static bool IsUnique(int[] arr).
*/
namespace Test {
  internal class UniqueRandomArrayDemo {
    static bool IsUnique(int[] arr) {
      return arr.Distinct().Count() == arr.Length;
    }
    public static int[] GetUniqueRandomArray(int size, int min = 0, int max = int.MaxValue) {
      var picked = new HashSet<int>(size);
      var rnd = new Random();
      int num;
      var arr = new int[size];
      for (int i = 0; i < size; i++) {
        do {
          num = rnd.Next(0, size);
        } while (picked.Contains(num));
        arr[i] = num;
        picked.Add(num);

      }
      return arr;
    }
    public static void Demo() {
      Stopwatch sw = new Stopwatch();
      sw.Start();
      Console.WriteLine("stopwatch started");
      var arr = GetUniqueRandomArray(1000000);
      sw.Stop();
      Console.WriteLine($"{IsUnique(arr)} {sw.Elapsed}");
    }
  }
}
