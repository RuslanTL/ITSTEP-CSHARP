using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep {
  class MatrixTransformDemo {
    /*
Problem 03 (MatrixTransform)
Переставьте строки в матрице double [,]
  - по возрастанию суммы чисел в строке
  - по убыванию количества отрицательных чисел в строке
  - по возрастанию наименьшего элемента в строке
  - по убыванию наибольшего элемента в строке
*/

    static void MatrixTransformSum(double[,] matrix) {
      var length = matrix.GetLength(0);
      var width = matrix.GetLength(1);
      var lineList = new List<List<double>>();
      Console.WriteLine("untransformed: ");
      Utils.PrintMatrix(matrix);
      for (int i = 0; i < length; i++) {
        lineList.Add(new List<double>());
        for(int j= 0; j < width; j++) {
          lineList[i].Add(matrix[i,j]);
        }
      }
      lineList.Sort((x, y) => {
        return x.Sum().CompareTo(y.Sum());
      });
      for (int i = 0; i < length; i++) {
        for (int j = 0; j < width; j++) {
          matrix[i, j] = lineList[i][j];
        }
      }
      Console.WriteLine("transformed by sum of lines: ");
      Utils.PrintMatrix(matrix);
    }

    public static void Demo() {
      var matrix = Utils.GetDoubleMatrix(3, 3, max: 100);
      MatrixTransformSum(matrix);
    }
  }
}
