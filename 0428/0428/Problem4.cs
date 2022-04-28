using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 04
Напишите метод
static double[,] CombineMatrices (double[,] mat1, double[,] mat2, Func<double, double, double> f)
производящий поэлементное вычисление mat[i, j] = f(mat1[i, j], mat2[i, j] и возвращающий итоговую матрицу. Обеспечьте проверку mat1 и mat2 на идентичность размеров.
Продемонстрируйте работу для нескольких функций f.
*/
namespace _0428 {
  public class Problem4 {
    static double[,] CombineMatrices(double[,] mat1, double[,] mat2, Func<double, double, double> f) {
      if (mat1.GetLength(0) != mat2.GetLength(0) || mat1.GetLength(1) != mat2.GetLength(1)) {
        throw new Exception("the parameter matrices must have exact same dimensions!");
      }
      double[,] matrix = new double[mat1.GetLength(0),mat1.GetLength(1)];
      for(int i=0; i< matrix.GetLength(0); i++) {
        for(int j =0; j< matrix.GetLength(1); j++) {
          matrix[i, j] = f(mat1[i, j], mat2[i, j]);
        }
      }
      return matrix;
    }

    public static void Demo() {

    }
  }
}
