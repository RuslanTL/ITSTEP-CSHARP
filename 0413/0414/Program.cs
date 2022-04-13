// See https://aka.ms/new-console-template for more information
global using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 02
Создайте массив студентов:
Student[] studentArr = new Student[100];
Создайте 5 студентов и внесите их в первые элементы массива.
Распечатайте построчно содержимое всех 100 элементов массива.
Корректно обрабатывайте (предотвращайте) ошибки при распечатке!



Problem 03
Реализуйте два метода 
void ArrInfo1(double[] arr, . . .)
. .  ArrInfo2(double[] arr)
позволяющие получить минимальное, максимальное и среднее значения массива с помощью:
1) out - параметров
2) tuple

Продемонстрируйте работу на случайном массиве из 100_000_000 элементов.
*/
namespace _0414 {

  class Program {
    static void fillArr(double[] arr) {
      var rnd = new Random();
      for(int i=0; i < arr.Length; i++) {
        arr[i] = rnd.NextDouble() * 10;
      }
    }
    static void ArrInfo1(double[] arr, out double min, out double max, out double avg) {
      min = arr.Min();
      max = arr.Max();
      avg = arr.Average();
    }
    static (double min, double max, double avg) ArrInfo2(double[] arr) {
      double min = arr.Min();
      double max = arr.Max();
      double avg = arr.Average();
      return (min, max, avg);
    }
    static void Demo1() {
      Student student1 = new Student();
      Student student2 = new Student("847594039481", "Student", "Random", new DateTime(2005, 01, 09));
      WriteLine(student1);
      WriteLine(student2);
      student1.Rating = 10;
      WriteLine(student1.Rating);
      try {
        student2.Rating = 14;
      } catch (Exception e) {
        WriteLine(e);
      }
    }
    static void Demo2() {
      Student[] studentArr = new Student[100];
      for (int i = 0; i < studentArr.Length; i++) {
        studentArr[i] = new Student();
      }

      Student student1 = new Student("847594039481", "Student", "Random", new DateTime(2005, 01, 09));
      Student student2 = new Student("327589274589", "Student", "Randomer", new DateTime(2008, 11, 23));
      Student student3 = new Student("834513345456", "Student", "Randomest", new DateTime(2002, 08, 12));
      Student student4 = new Student("123452463275", "Doe", "Jane", new DateTime(2004, 04, 14));
      Student student5 = new Student("532458904995", "Know", "I dont", new DateTime(2005, 12, 12));

      studentArr[0] = student1;
      studentArr[1] = student2;
      studentArr[2] = student3;
      studentArr[3] = student4;
      studentArr[4] = student5;


      for(int i =0; i < studentArr.Length; i++) {
        WriteLine(studentArr[i]);
      }
    }

    static void Demo3() {
      double[] arr1 = new double[100_000_000];
      fillArr(arr1);
      double min, max, avg;
      ArrInfo1(arr1, out min, out max, out avg);
      WriteLine($"min: {min}");
      WriteLine($"max: {max}");
      WriteLine($"avg: {avg}");

    }
    static void Demo4() {
      double[] arr1 = new double[100_000_000];
      fillArr(arr1);
      (double min, double max, double avg) = ArrInfo2(arr1);
      WriteLine($"min: {min}");
      WriteLine($"max: {max}");
      WriteLine($"avg: {avg}");
    }
    static void Main(string[] args) {
      //Demo1();
      //Demo2();
      //Demo3();
      Demo4();

    }
  }
}