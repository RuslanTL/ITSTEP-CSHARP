/*Problem 01
Найдите строки матрицы размером 10_000 * 10_000, содержащие наибольшую разницу между максимальным элементом и средним значением в строке. 



Problem 02
В массиве случайных целых чисел размером size = 100_000_000 найдите все числа, встречающиеся менее n1 и более n2 раз включительно.
int[] GetNumbers(int[] arr, int n1, int n2)



Problem 03
Используя файл students_10_000_000.txt, выведите список GroupID и число студентов в группе (по возрастанию числа студентов) в файл results.txt.



Problem 04 (дополнительно)
В папке "C:\Program Files (x86)" найдите папку верхнего уровня, содержащую наибольшее количество файлов в себе и в собственных подпапках.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam;

class Program {
  public static void Main(string[] args) {

    try {
      MaxAndAvgDemo.Demo();
      FindNumbersDemo.Demo();
      GroupStudentCountDemo.Demo();
      FindMaxFilesDemo.Demo();
    }catch(Exception ex) {
      Console.WriteLine(ex.Message);
    }

  }
}
