// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


//Problem 00
//Напишите функцию создания нулевой матрицы:
//static double[,] CreateZeroMatrix(int nRow, int nCol)
//Сделайте необходимую проверки аргументов!
//(throw new Exception("К-во строк должно быть положительным!");)

class Problem_06
{ 
  static double[,] CreateZeroMatrix(int nRow, int nCol)
  {
    if (nRow <= 0 || nCol <= 0)
    {
      throw new Exception("The row or column size must be positive!");
    }
    double[,] zero = new double[nRow, nCol];
    //for(int i = 0; i < nRow; i++)
    //{
    //  for(int j=0; j< nCol; j++)
    //  {
    //    zero[i, j] = 0;
    //  }
    //}
    return zero;
    
  }
  static void PrintMatrix(double[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0)-1; i++) {
      for (int j = 0; j < matrix.GetLength(1)-1; j++) {
        Write($"{matrix[i, j]}  ");
      }
      WriteLine("");
    }
  }



  //  Problem 07
  //Напишите функцию создания единичной матрицы, то есть квадратной с главной диагональю, заполненной значениями 1.
  //static double[,] CreateIdentityMatrix(int nRow)
  //Распечатайте с помощью PrintMatrix.

  static double[,] CreateIdentityMatrix(int size) {
    var identity = new double[size, size];
    for (int i = 0; i < size; i++) {
      for (int j = 0; j < size; j++) {
        if (i == j) {
          identity[i, j] = 1;
        } else {
          identity[i,j] = 0;
        }
      }
    }
    return identity;
  }
  static void Main(string[] args)
  {
    WriteLine("zero matrix: ");
    double[,] m1 = CreateZeroMatrix(8, 6);
    PrintMatrix(m1);

    WriteLine("identity matrix: ");
    double[,] square = CreateIdentityMatrix(10);
    PrintMatrix(square);
  }
}