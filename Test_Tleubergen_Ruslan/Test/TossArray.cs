
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/*Problem 02
По мотивам идеи предыдущей задачи, напишите метод
static int[] MakeTossArray(int size),
возвращающий массив интервала 1 - size, переставленных случайным образом.

Автоматизируйте вывод результатов по нижеприведенному образцу.
Возвращаемый массив проверяйте на уникальность чисел с помощью метода
static bool IsUnique(int[] arr)
Измеряйте только времена работы метода MakeTossArray (включая время создания массива в методе)!

Мой результат:

size =           10, time elapsed = 00:00:00.0006739    True
size =          100, time elapsed = 00:00:00.0000137    True
size =         1000, time elapsed = 00:00:00.0000273    True
size =        10000, time elapsed = 00:00:00.0001421    True
size =       100000, time elapsed = 00:00:00.0014847    True
size =      1000000, time elapsed = 00:00:00.0171935    True
size =     10000000, time elapsed = 00:00:00.3619935    True
size =    100000000, time elapsed = 00:00:04.2002046    True
size =   1000000000, time elapsed = 00:01:02.3136130    True

End . . .
*/
namespace Test {
  internal class TossArray {
    static int[] MakeTossArray(int size) {
      var arr = new int[size];
      var rnd = new Random();
      var picked = new HashSet<int>();
      int num;
      for (int i=0; i < size;i++) {
        do {
          num = rnd.Next(0, size);
        } while (picked.Contains(num));
        arr[i] = num;
        picked.Add(num);
        
      }
      return arr;
    }
    static bool IsUnique(int[] arr) {
      return arr.Distinct().Count() == arr.Length;
    }
    public static void Demo() {

      var sw = new Stopwatch();
      int size = 10;
      for(int i =0; i < 8; i++) {
        sw.Restart();
        var arr = MakeTossArray(size);
        sw.Stop();
        Console.WriteLine($"size = {size,12}, time elapsed = {sw.Elapsed}, is unique: {IsUnique(arr)}");
        size *= 10;
      }
    }
  }
}
