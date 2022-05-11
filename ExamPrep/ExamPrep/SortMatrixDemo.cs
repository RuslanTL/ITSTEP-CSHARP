using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep {
  /*
Problem 02
Написать методы, переставляющие элементы в матрице double [,]:
 - по возрастанию по строкам:
  1  2  3  3
  3  6  7  8
 10 11 12 13

 - по убыванию по столбцам:
  13 10  6  3 
  12  8  3  2
  11  7  3  1
*/
  internal class SortMatrixDemo {

    static void SortMatrixByLines<T>(T[,]matrix, bool column = false) where T:IComparable<T> {
      Console.WriteLine("unsorted: ");
      Utils.PrintMatrix(matrix);
      int length = matrix.GetLength(0);
      int width = matrix.GetLength(1);
      var line = new List<T>();
      if (!column) {
        for (int i = 0; i < length; i++) {
          for (int j = 0; j < width; j++) {
            line.Add(matrix[i, j]);
          }
          line.Sort();
          for (int j = 0; j < width; j++) {
            matrix[i, j] = line[j];
          }
          //line.Sort((x,y)=>-x.CompareTo(y));
          line.Clear();
        }

      } else {
        for (int i = 0; i < width; i++) {
          for (int j = 0; j < length; j++) {
            line.Add(matrix[j,i]);
          }
          line.Sort((x, y) => -x.CompareTo(y));
          for (int j = 0; j < length; j++) {
            matrix[j,i] = line[j];
          }
          line.Clear();
        }
      }
      Console.WriteLine("sorted: ");
      Utils.PrintMatrix(matrix);
    }
    public static void Demo() {
      var matrix = Utils.GetIntMatrix(6, 6, max: 20);
      SortMatrixByLines(matrix,true);
    }
  }
}
