using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam {
  internal class FindNumbersDemo {

    /*Problem 02
В массиве случайных целых чисел размером size = 100_000_000 найдите все числа, встречающиеся менее n1 и более n2 раз включительно.
int[] GetNumbers(int[] arr, int n1, int n2)
*/
    static int[] FindNumbers(int[] arr, int n1, int n2) {
      var nums = new Dictionary<int, int>();
      var foundNums = new List<int>();
      for (int i = 0; i < arr.Length; i++) {
        if (!nums.ContainsKey(arr[i])){
          nums.Add(arr[i], 1);
        } else {
          nums[arr[i]] += 1;
        }
      }
      foreach(KeyValuePair<int,int> item in nums) {
        Console.WriteLine(item);
        if (item.Value <= n1 || item.Value>=n2) {
          foundNums.Add(item.Key);
        }
      }
      return foundNums.ToArray();
    }

    public static void Demo() {
      int size = 100_000_000;
      int n1 = 999000;
      int n2 = 1002000;
      var arr = Utils.GetIntArray(size,0,100);
      Utils.PrintArray(arr,4);
      var found = FindNumbers(arr, n1, n2);
      Console.WriteLine($"\nall numbers in array that occur fewer than {n1} or more than {n2} times:");
      Utils.PrintArray(found,4,printAll:true);
    }
  }
}