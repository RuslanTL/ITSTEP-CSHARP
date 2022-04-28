using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*static void Transform(double[] arr, Func<double, double> f) 
static void Transform(List<double> list, Func<double, double> f) 

Создайте исходные массив и List. Вызывайте данные методы для КОПИЙ массива и List c различными встроенными и своими (используя ламбда-выражения) функциями (Math.Abs, Sin, Cos, Exp, Log10, . . .).
Результаты выводите с помощью Utils.PrintArray и Utils.PrintList.
*/
namespace _0428 {
  public class Problem2 {
    static void Transform(double[] arr, Func<double, double> f) {
      for(int i =0; i< arr.Length; i++) {
        arr[i] = f(arr[i]);
      }
    }
    static void Transform(List<double> list, Func<double, double> f) {
      for (int i = 0; i < list.Count; i++) {
        list[i] = f(list[i]);
      }
    }

    public static void Demo() {
      int size = 10;
      Func<double, double> f1 = (x) => Math.Pow(x, 2);
      var arr1 = Utils.GetDoubleArray(size, max: 20);
      var list1 = Enumerable.ToList(Utils.GetDoubleArray(size, max: 20));

      Console.WriteLine("\nArray square function");
      Utils.PrintArray(arr1,decimals:4);
      var arr_copy = arr1;
      Transform(arr_copy, f1);
      Utils.PrintArray(arr_copy, decimals: 4);

      Console.WriteLine("\nList round function");

      Func<double, double> f2 = (x) => Math.Round(x);
      Utils.PrintList(list1, decimals: 4);
      var list_copy = list1;
      Transform(list_copy, f2);
      Utils.PrintList(list_copy, decimals: 4);

    }
  }
}
