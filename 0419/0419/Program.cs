using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _0419 {
  public class Student {
    public string name = "";
  }
  class Program {

        /*
    Problem 02
    Напишите ряд методов, в каждом из которых выбрасывается и не обрабатывается исключение:
     - деление на ноль;
     - попытка выхода за пределы массива, например - arr[-10], arr[1_000_000];
     - попытка доступа к символу за пределами строки, например - name[1000];
     - попытка обратиться к члену несуществующего объекта, например Student bear = null; bear.Name = "Pooh";
     - и  т.п.
    Реализуйте в методе, вызывающим данные все методы поочередно,
    static void CallAll() 
    обработку исключений с выдачей пользователю пояснительной информации на консоль.

    */

    static int DivideByZero(int n) {
      try {
        return n / 0;
      }catch(DivideByZeroException ex) {
        WriteLine(ex);
        return -1;
      }
    }
    static void GetItem(int[] arr, int idx) {
      try {
        WriteLine(arr[idx]);
      } catch(IndexOutOfRangeException ex) {
        WriteLine(ex);
      }
    }
    static void GetChar(string str, int idx) {
      try {
        WriteLine(str[idx]);

      }catch(IndexOutOfRangeException ex) {
        WriteLine(ex);
      }
    }
    static void ChangeName(Student st) {
      try {
        st.name = "Test";
      }catch(NullReferenceException ex) {
        WriteLine(ex);
      }
    }

    static void CallAll() {
      DivideByZero(1);
      int[] arr1 = new int[5];
      GetItem(arr1, 9_999_999);
      string str1 = "the quick fox jumped over the lazy dog";
      GetChar(str1, 9_999_999);
      Student st1 = null;
      ChangeName(st1);
    }


    /*static void Main(string[] args) {
      CallAll();
    }*/
  }
}
