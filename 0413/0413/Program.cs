// See https://aka.ms/new-console-template for more information
global using static System.Console;



/*Problem 00
Измерьте время выполнения какой-либо длительной операции с помощью класса Stopwatch. Смотрите Snippets\timing.cs.







Problem 03
Напишите метод
public static int MaxIdenticalNumbersCount(int[] arr),
возврашающий максимальное количество одинаковых чисел в массиве.


Problem 04 - OrderedMatrix
"OrderedMatrix.txt".


Problem 05 - SimpleMergeSort
Заполните два массива целых чисел длины nLen1= 200_000 , nLen2=400_000 случайными четными и нечетными целыми числами соответственно в возрастающем порядке (можно отсортировать массивы после формирования). Выходной массив длины nLen1 + nLen2 должен содержать их объединение в возрастающем порядке. Не прибегая к сортировке, найдите предельно быстрый способ заполнения выходного массива.
Сделайте полную автоматическую проверку результата.
Выведите начальные и конечные части каждого массива.
[6 8 14 44 58 62 . . . ] + [3 5 11 23 27 47 . . . ] =
[3 5 6 8 11 23 27 44 47 62 ]*/


class Program {
  static void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
      for (int j = 0; j < matrix.GetLength(1); j++) {
        Write($"{matrix[i, j],4}");
      }
      WriteLine("");
    }
  }

  /*Problem 01 (SortInside)
Напишите метод для сортировки элементов внутри одномерного массива типа long между индексами iMin и iMax. Вне данного интервала числа должны остаться на своих местах.
static void SortInside(long[] arr, int iMin, int iMax). 
Приведите убедительную демонстрацию правильной работы метода.*/

  static void SortInside(long[] arr, int iMin, int iMax) {
    WriteLine($"unsorted array: ");
    for (int i = 0; i < arr.Length; i++) {
      Write($"{arr[i]}  ");
    }
    WriteLine(" ");
    long temp;
    for (int i = iMin; i < iMax; i++) {
      if (arr[i] > arr[i + 1]) {
        temp = arr[i + 1];
        arr[i + 1] = arr[i];
        arr[i] = temp;
      }
    }
    WriteLine($"sorted array between indexes {iMin} and {iMax}: ");
    for (int i = 0; i < arr.Length; i++) {
      Write($"{arr[i]}  ");
    }
  }

  /*  Создание случайной матрицы со значениями элементов от min до max 
  static int[,] CreateRandomMatrix(int nRows, int nCols, int min = 0, int max = int.MaxValue)*/
  static int[,] CreateRandomMatrix(int nRows, int nCols, int min = 0, int max = int.MaxValue) {
    int[,] matrix = new int[nRows, nCols];
    var rnd = new Random();
    for (int i = 0; i < nRows; i++) {
      for (int j = 0; j < nCols; j++) {
        matrix[i, j] = rnd.Next(min, max);
      }
    }
    return matrix;
  }
  /*
  Сортировка по строке row
  static void SortRow(int[,] mat, int row)

  Сортировка по столбцу col
  static void SortCol(int[,] mat, int col)

  Сортировка по строкам (сортировка всех строк по отдельности)
  static void SortRows(int[,] mat)

  Сортировка по столбцам (сортировка всех столбцов по отдельности)
  static void SortCols(int[,] mat) {*/
  //static void SortRow(int[,] mat, int row) {
  //    int rowLength = mat.GetLength(1);
  //    for (int i = 0; i < rowLength - 1; i++) {
  //        for (int j = 0; j < rowLength - i - 1; j++) {
  //            if (mat[row, j] > mat[row, j + 1]) {
  //                int temp = mat[row, j];
  //                mat[row, j] = mat[row, j + 1];
  //                mat[row, j + 1] = temp;
  //            }
  //        }

  //    }
  //}
  //static void SortCol(int[,] mat, int col) {
  //    int colLength = mat.GetLength(0);
  //    for (int i = 0; i < colLength - 1; i++) {
  //        for (int j = 0; j < colLength - i - 1; j++) {
  //            if (mat[j, col] > mat[j + 1, col]) {

  //                int temp = mat[j, col];
  //                mat[j, col] = mat[j + 1, col];
  //                mat[j + 1, col] = temp;
  //            }

  //        }
  //    }
  //}
  static void SortRows(int[,] mat) {
    int rowLength = mat.GetLength(1);
    int colLength = mat.GetLength(0);

    for (int k = 0; k < colLength; k++) {
      for (int i = 0; i < rowLength - 1; i++) {
        for (int j = 0; j < rowLength - i - 1; j++) {
          if (mat[k, j] > mat[k, j + 1]) {
            int temp = mat[k, j];
            mat[k, j] = mat[k, j + 1];
            mat[k, j + 1] = temp;
          }
        }
      }
    }
  }
  static void SortCols(int[,] mat) {
    int rowLength = mat.GetLength(1);
    int colLength = mat.GetLength(0);

    for (int k = 0; k < rowLength; k++) {
      for (int i = 0; i < colLength - 1; i++) {
        for (int j = 0; j < colLength - i - 1; j++) {
          if (mat[j, k] > mat[j + 1, k]) {

            int temp = mat[j, k];
            mat[j, k] = mat[j + 1, k];
            mat[j + 1, k] = temp;
          }

        }
      }
    }

  }

  static void SortRow(int[,] mat, int row) {
    int rowLength = mat.GetLength(1);
    int[] rowCopy = new int[rowLength];


    for (int i = 0; i < rowLength; i++) {
      rowCopy[i] = mat[row, i];

    }
    Write($"\n selected row: \n");
    for (int i = 0; i < rowCopy.Length; i++) {
      Write($"{rowCopy[i],4}");
    }
    Array.Sort(rowCopy);
    for (int i = 0; i < rowLength; i++) {
      mat[row, i] = rowCopy[i];

    }

    Write("\n\n");
  }

  static void SortCol(int[,] mat, int col) {
    int colLength = mat.GetLength(1);
    int[] colCopy = new int[colLength];


    for (int i = 0; i < colLength; i++) {
      colCopy[i] = mat[i, col];

    }
    Write($"\n selected col: \n");
    for (int i = 0; i < colCopy.Length; i++) {
      Write($"{colCopy[i],4}");
    }
    Array.Sort(colCopy);
    for (int i = 0; i < colLength; i++) {
      mat[i, col] = colCopy[i];

    }

    Write("\n\n");
  }
  /*
  Problem 03
  Напишите метод
  public static int MaxIdenticalNumbersCount(int[] arr),
  возврашающий максимальное количество одинаковых чисел в массиве.8*/
  public static int MaxIdenticalNumbersCount(int[] arr) {
    var counts = new Dictionary<int, int>();
    Array.Sort(arr);
    for (int i = 0; i < arr.Length; i++) {
      Write($"{arr[i],3}");
    }
    WriteLine(" ");
    int num = 0;
    int cnt = 1;
    for (int i = 0; i < arr.Length - 1; i++) {
      if (arr[i] == arr[i + 1]) {
        cnt++;
        num = arr[i];
      } else {
        counts.Add(arr[i], cnt);
        cnt = 1;
        num = arr[i + 1];
      }
    }
    int max = 0;
    int maxKey = 0;
    for (int i = 0; i < counts.Count; i++) {
      if (counts.ElementAt(i).Value > max) {
        max = counts.ElementAt(i).Value;
        maxKey = counts.ElementAt(i).Key;
      }
      Write($"{counts.ElementAt(i),3}");
    }
    WriteLine($"\nmax amount of occurances: {maxKey} found {max} times in array");
    return num;
  }

  /*Problem OrderedMatrix
Матрица сортируется в порядке возрастания сначала по строкам, затем - по столбцам.
Оказывается (попробуйте доказать самостоятельно!), что после сортировки по столбцам, строки остаются по-прежнему в отсортированном состоянии!

Напишите программу для проверки данной теоремы.
Сделайте, в частности, проверку для матриц предельных размеров.

Реализуйте следующие методы:
Создание случайной матрицы со значениями элементов от 0 до max 
static int[,] CreateRandomMatrix(int nRows, int nCols, int max)

Распечатка матрицы (для больших матрих выводить только первые 10 строк и столбцов)    
static void PrintMatrix(int[,] mat)

Сортировка по строкам
static void SortRows(int[,] mat)

Сортировка по столбцам
static void SortCols(int[,] mat) {

Проверка факта, что строки остаются в отсортированном состоянии
static bool CheckMatrixRegularity(int[,] mat) {*/

  static bool CheckMatrixRegularity(int[,] mat) {
    return true;
  }


  static void Demo1() {
    long[] arr1 = { 3, 2, 6, 8, 1, 2, 9, 4, 8, 2 };
    SortInside(arr1, 0, 3);
    int row = 8; int col = 5;
    int[,] matrix1 = CreateRandomMatrix(row, col, max: 100);
    WriteLine("\n\nmatrix:");
    PrintMatrix(matrix1);
    WriteLine("");
    var r = 3;
    SortRow(matrix1, r);
    WriteLine($"\n\n sorted matrix at row {r + 1}:");
    PrintMatrix(matrix1);
    WriteLine("");
    var c = 0;
    SortCol(matrix1, c);
    WriteLine($"\n\n sorted matrix at column {c + 1}:");
    PrintMatrix(matrix1);
    WriteLine("");
    SortRows(matrix1);
    WriteLine($"\n\n sorted matrix at all rows:");
    PrintMatrix(matrix1);
    WriteLine("");
    SortCols(matrix1);
    WriteLine($"\n\n sorted matrix at all columns:");
    PrintMatrix(matrix1);
  }

  static void Demo2() {
    int[] arr1 = { 1, 4, 3, 5, 1, 1, 5, 3, 3, 2, 3 };
    MaxIdenticalNumbersCount(arr1);
  }
  static void Demo3() {
    int row = 8; int col = 5;
    int[,] matrix1 = CreateRandomMatrix(row, col, max: 100);
    PrintMatrix(matrix1);
    SortRow(matrix1, 2);
    PrintMatrix(matrix1);
  }
  static void Main(string[] args) {
    //Demo1();
    //Demo2();
    Demo3();

  }
}
























