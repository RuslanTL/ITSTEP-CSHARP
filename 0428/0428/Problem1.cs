using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Приведите собственные примеры использования следующих Func and Action delegates (аналогично демонстрациям BasicDemo и LambdaDemo):
delegate TResult Func<TResult>();
delegate TResult Func<T, TResult>(T arg);
delegate TResult Func<T1, T2, TResult> (T1 arg1, T2 arg2);
delegate void Action();
delegate void Action<T>(T arg);
delegate void Action<T1, T2>(T1 arg1, T2 arg2);
			*/

namespace _0428 {

  public class Problem1 {
    public static void Demo() {
      Func<double> f0 = () => Math.Sin(45);
      Console.WriteLine($"{f0()}");
      double a = 25;
      Func<double, double> f1 = Common.Sqrt;
      Console.WriteLine($"Sqrt of {a}: {f1(a)}");

      Func<double, double, double> f2 = Common.Log;
      double b = 16;
      double c = 4;
      Console.WriteLine($"logarithm of {b} base {c}: {f2(b, c)}");

      Action a0 = () => Console.WriteLine($"Hello I am Action");
      a0();
      Action<double> a1 = (x) => { a0(); Console.WriteLine($"Sqrt of {x}: {f1(x)}"); };
      a1(144);
      Action<string, int> a2 = (str, repeat) => {
        for (int i = 0; i < repeat; i++) {
          Console.WriteLine($"{i} {str}");
        }
      };

      a2("Goodbye World",20);
    }
  }
}
