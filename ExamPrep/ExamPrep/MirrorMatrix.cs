using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep {
  /*Напишите метод транспонирующий матрицу (зеркально отображающий относительно главной диагонали) n*m -> m*n.*/
  public class MirrorMatrixDemo {

    public static T[,] MirrorMatrix<T>(T[,] matrix) {
      Console.WriteLine("unmirrored: ");
      Utils.PrintMatrix(matrix);

      var newMatrix = new T[matrix.GetLength(1), matrix.GetLength(0)];
      for(int i=0; i< matrix.GetLength(0); i++) {
        for(int j=0; j < matrix.GetLength(1); j++) {
          newMatrix[j, i] = matrix[i, j];
        }
      
      }
      Console.WriteLine("mirrored: ");
      Utils.PrintMatrix(newMatrix);
      return newMatrix;
    }
    public static void Demo() {
      int w = 7;
      int l = 7;
      var mat = new int[l,w];
      for(int i = 0; i < l; i++) {
        for(int j = 0; j < w; j++) {
          if (j >= i) {
            mat[i, j] = 1;
          } else mat[i, j] = 0;
        }
      }
      MirrorMatrix(mat);
    }

  }
}
