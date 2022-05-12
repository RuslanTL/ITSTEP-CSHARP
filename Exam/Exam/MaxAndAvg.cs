using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam {
  /*Problem 01
Найдите строки матрицы размером 10_000 * 10_000, содержащие наибольшую разницу между максимальным элементом и средним значением в строке. */
  internal class MaxAndAvgDemo {
    static List<int> MaxAndAvg(){
      int length = 10;
      int width = length;
      var matrix = Utils.GetIntMatrix(length,width,0,20);
      var line = new List<int>(10000);
      var maxRangeLine = new List<int>();
      int max = matrix[0,0];
      double avg = 0;
      double prevDiff = 0;
      double diff = 0;
      for (int i = 0; i < length; i++) {
        for (int j = 0; j < width; j++) {
          line.Add(matrix[i, j]);
        }
        line.Sort();
        
        max = line.Max();
        avg = line.Average();
        diff = max - avg;
        //Utils.PrintList(line, 3, printAll: true);
        //Console.WriteLine($"{max} | {avg,0:F1} | {diff,0:F1}\n");
        if (diff > prevDiff) {
          //Console.WriteLine("bigger");
          maxRangeLine = line.ToList();
          prevDiff = diff;
        }

        line.Clear();
      }

      return maxRangeLine;
    }

    public static void Demo() {
      var maxRangeLine = MaxAndAvg();
      var max = maxRangeLine.Max();
      var avg = maxRangeLine.Average();
      var diff = max - avg;
      Console.WriteLine($"Max range line: ");
      Utils.PrintList(maxRangeLine);
      Console.WriteLine($"max number: {max} avg number: {avg} difference: {diff}");
    }
  }
}
