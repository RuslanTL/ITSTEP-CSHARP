using System.Diagnostics;


// See https://aka.ms/new-console-template for more information
/*Problem 00 - ArrayListSort
Измерьте времена сортировки массива целых чисел и List<int> размера size = 1_000_000_000, одинаково заполненных случайными числами в интервале (int.MinValue, int.MaxValue).
Сравните результаты в режимах Release, x64 и Debug, x64.
Дома, повторив и усреднив результаты нескольких измерений, составьте сводную таблицу в Excel (см. result.xlsx). 



Problem 01
Напишите метод, проверяющий, являются ли все элементы одномерного массива целых чисел уникальными (неповторяющимися):
public static bool IsUnique(int[] arr).



Problem 02
Напишите метод для сортировки List студентов по фамилии, имени и дате рождения 
public static int CompareByLastFirstNameBirthday(Student a, Student b).
Отсортируйте List 10_000_000 студентов.
Измерьте время сортировки.
Выведите на печать с помощью Utils.PrintListByLines(studArr).



Problem 03
Отсортируйте List 1_000_000 групп в порядке:
 - возрастания по GroupName
 - убывания по GroupId.
Измерьте время каждой сортировки.
*/

namespace _0425 {
  class Program {
    static int[] fillArr(int size, int min = int.MinValue, int max = int.MaxValue) {
      var rnd = new Random();
      int[] result = new int[size];
      for(int i = 0; i < size; i++) {
        result[i] = rnd.Next(min,max);
      }
      return result;
    }
    static List<int> fillList(int size, int min = int.MinValue, int max = int.MaxValue) {
      var rnd = new Random();
      var result = new List<int>();
      for(int i = 0; i < size; i++) {
        result.Add(rnd.Next(min,max));
      }
      return result;
    }
    public static bool IsUnique(int[] arr) {
      return arr.Distinct().Count() == arr.Length;
    }
    static void Demo1() {


      Console.WriteLine($"array creation started");
      var sw = new Stopwatch();
      sw.Restart();
      var arr1 = fillArr(100_000_000);
      sw.Stop();
      Console.WriteLine($"array creation Time elapsed: {sw.Elapsed}\n");

      sw.Restart();
      Console.WriteLine($"list creation started");
      var list1 = fillList(100_000_000);
      sw.Stop();
      Console.WriteLine($"list creation Time elapsed: {sw.Elapsed}\n");
    }
    static void Demo2() {
      int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };

      Console.WriteLine($"arr1 unique: {IsUnique(arr1)}");
      Console.WriteLine($"arr2 unique: {IsUnique(arr2)}");
    }

    static void Demo3() {

      Console.WriteLine($"getting student list...");
      var studentList = StudentsNS.Student.GetStudentList("C:/_0/students_10_000_000.txt",1_000_000);
      Console.WriteLine($"list sort started");
      var sw = new Stopwatch();
      sw.Restart();
      studentList.Sort(StudentsNS.Student.CompareByLastFirstNameBirthday);
      sw.Stop();
      Console.WriteLine($"list sort Time elapsed: {sw.Elapsed}\n");
      UtilsNS.Utils.PrintListByLines(studentList);


    }
    static void Demo4() {
      Console.WriteLine($"getting group list...");
      var groupList = StudentsNS.Group.GetGroupsList("C:/_0/groups_1_000_000.txt", 1_000_000);
      Console.WriteLine($"list sort started");
      var sw = new Stopwatch();
      sw.Restart();
      groupList.Sort(StudentsNS.Group.CompareByGroupName);
      sw.Stop();
      Console.WriteLine($"sort by group name Time elapsed: {sw.Elapsed}\n");
      UtilsNS.Utils.PrintListByLines(groupList);
      sw.Restart();
      groupList.Sort(StudentsNS.Group.CompareByGroupId);
      groupList.Reverse();
      sw.Stop();
      Console.WriteLine($"sort by group id Time elapsed: {sw.Elapsed}\n");
      UtilsNS.Utils.PrintListByLines(groupList);
    }
    static void Main(string[] args) {
      //Demo1();
      //Demo2();
      //Demo3();
      Demo4();
    }

   

  }
}