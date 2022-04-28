using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 03 (PrintTable)
Напишите методы для вывода на консоль и в файл таблицу аргументов и значений переданной функции
static void PrintTable (List<double> args, Func<double, double> f, string columnName, string fileName = null)

Например: 
PrintTable(xList, (double x) => { return x * x; }, "x*x");
|    x    |     x*x     |
-------------------------
|  0,0000 |      0,0000 |
|  0,5000 |      0,2500 |
|  1,0000 |      1,0000 |
|  1,5000 |      2,2500 |
|  2,0000 |      4,0000 |
|  2,5000 |      6,2500 |
|  3,0000 |      9,0000 |
. . . . . . . . . . . . . . 
 		
Обеспечьте типографическое качество разметки!*/
namespace _0428 {
  class Problem3 {
    static void PrintTable(List<double> args, Func<double, double> f, string columnName, string fileName = "output.txt") {
      using (var file = new StreamWriter(fileName)) {
        file.WriteLine($"|{"x",8:N4}|{columnName,12:N4}|");
        file.WriteLine($"------------------------");
        for(int i =0; i< args.Count; i++) {
          file.WriteLine($"|{args[i],8:N4}|{f(args[i]),12:N4}|");
        }
        
      }
    }

    public static void Demo() {
      var list1 = Enumerable.ToList(Utils.GetDoubleArray(100, max: 10));
      list1.Sort();
      PrintTable(list1, (double x) => { return x*10; }, "x*10");
    }
  }
}
