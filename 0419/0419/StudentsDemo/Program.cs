using System;
using static System.Console;
using System.Diagnostics;

namespace StudentsNS {
  class Program {
    static string groupFileName = @"C:\_0\groups_1_000_000.txt";
    static string groupBadFileName = @"C:\_0\groups_bad.txt";

    static string studentFileName = @"C:\_0\students_10_000_000.txt";
    static void TimingDemo() {
      int size = 8;
      int size2 = 1_000_000;

      var sw = new Stopwatch();
      sw.Restart();
      var groupArr = Group.GetGroupsArr(groupFileName, size);
      sw.Stop();
      Console.WriteLine($"Time elapsed: {sw.Elapsed}\n");
      Group.PrintArray(groupArr);
      WriteLine("\n------------------------------\n");
      sw.Restart();
      var studentArr = Student.GetStudentsArr(studentFileName, size2);
      sw.Stop();
      Console.WriteLine($"Time elapsed: {sw.Elapsed}\n");
      Student.PrintArray(studentArr);
      WriteLine("");


    }
    static void Main(string[] args) {
      TimingDemo();
      //try {
      //  var groupArr = Group.GetGroupsArr(groupFileName, 10);
      //  Group.PrintArray(groupArr);
      //  WriteLine();

      //  groupArr = Group.GetGroupsArr(groupBadFileName, 10);
      //  Group.PrintArray(groupArr);

      //} catch (Exception ex) {
      //  WriteLine(ex.Message);
      //}
      //WriteLine("\nEnd . . .");
      //ReadLine();


    }
  }
}
