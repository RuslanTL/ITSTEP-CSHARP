using System.Diagnostics;
using UtilsNS;

namespace StudentsNS;
public class Sorting {


  static void ArraySortingDemo() {
    int size = 100;
    var sw = new Stopwatch();
    var groupArr = Group.GetGroupsArr(Globals.GroupFileName, 10);
    Utils.PrintArrayByLines(groupArr);

    sw.Restart();
    var studArr = Student.GetStudentArr(Globals.StudentFileName, size);
    WriteLine($"reading file and creating array time: {sw.Elapsed}\n");
    WriteLine("Students:");
    Utils.PrintArrayByLines(studArr);

    sw.Restart();
    Array.Sort(studArr, Student.CompareByIIN);
    WriteLine($"sorting by IIN time: {sw.Elapsed}\n");
    WriteLine("Students, sorted by IIN:");
    Utils.PrintArrayByLines(studArr);


    Array.Sort(studArr, Student.CompareByLastFirstName);
    WriteLine("\nStudents, sorted by LastName, FirstName:");
    Utils.PrintArrayByLines(studArr);


    Array.Sort(studArr, (x, y) => x.FirstName.CompareTo(y.FirstName));
    WriteLine("\nStudents, sorted by FirstName (with lambda expression):");
    Utils.PrintArrayByLines(studArr);


    Array.Sort(studArr, (a, b) => {
      int result = a.LastName.CompareTo(b.LastName);
      if (result != 0) {
        return result;
      } else {
        return a.FirstName.CompareTo(b.FirstName);
      }
    });
    WriteLine("\nStudents, sorted by LastName, FirstName (with lambda expression): ");
    Utils.PrintArrayByLines(studArr);
  }



  static void ListSortingDemo() {
    int size = 100;
    var studList = Student.GetStudentList(Globals.StudentFileName, size);

    studList.Sort(Student.CompareByIIN);
    WriteLine("Students, sorted by IIN:");
    Utils.PrintListByLines(studList);


    studList.Sort((x, y) => x.IIN.CompareTo(y.IIN));
    WriteLine("Students, sorted by IIN (with lambda expression):");
    Utils.PrintListByLines(studList);
    Utils.PrintListByLines(studList);


    studList.Sort(Student.CompareByGroupId);
    studList.Sort((x, y) => x.GroupId.CompareTo(y.GroupId));
    WriteLine("Students, sorted by GroupId (with lambda expression):");
    UtilsNS.Utils.PrintListByLines(studList);
  }



  public static void Demo() {
    //ArraySortingDemo();
    ListSortingDemo();
  }
}

