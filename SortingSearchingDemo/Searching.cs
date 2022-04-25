using System.Diagnostics;

namespace StudentsNS;
class Searching {

  static void SimpleBinarySearchDemo() {
    int size = 1_000_000;

    var arr = UtilsNS.Utils.GetIntArray(size);
    int toFind = arr[0];
    //toFind = arr[0] + 1;

    Array.Sort(arr);

    int idx = Array.BinarySearch(arr, toFind);
    if (idx >= 0) {
      WriteLine($"{toFind} found at: {idx}");
      WriteLine(arr[idx]);
    } else {
      WriteLine("not found");
    }
    WriteLine();
  }



  public static int BinarySearchByIIN(Student[] studArr, string iIn) {
    int min = 0;
    int max = studArr.Length - 1;
    while (min <= max) {
      // instead of: int mid = (min + max) / 2;
      int mid = min + ((max - min) / 2);
      if (iIn == studArr[mid].IIN) {
        return mid;
      } else if (iIn.CompareTo(studArr[mid].IIN) < 0) {
        max = mid - 1;
      } else {
        min = mid + 1;
      }
    }
    return -1;
  }



  public static void BinaryArraySearchingDemo() {
    int size = 100;
    var studArr = Student.GetStudentArr(Globals.StudentFileName, size);

    Array.Sort(studArr, Student.CompareByIIN);
    UtilsNS.Utils.PrintArrayByLines(studArr);
    WriteLine();

    string iInToFind = "270907618397";


    WriteLine("By our BinarySearchByIIN method:");
    int idx = BinarySearchByIIN(studArr, iInToFind);
    if (idx >= 0) {
      WriteLine($"{iInToFind} found at: {idx}");
      WriteLine(studArr[idx]);
    } else {
      WriteLine("not found");
    }
    WriteLine();


    //for self study:
    //для самостоятельного изучения после ознакомления с extention - методами и интерфейсом IComparer
    var studForSearch = new Student { IIN = iInToFind };

    WriteLine("By our BinarySearch extention method:");
    idx = studArr.BinarySearch(studForSearch, Student.CompareByIIN);
    //or with lambda:
    //int idx = studArr.BinarySearch(studForSearch, (a, b) => a.IIN.CompareTo(b.IIN));
    if (idx >= 0) {
      WriteLine($"{iInToFind} found at: {idx}");
      WriteLine(studArr[idx]);
    } else {
      WriteLine("not found");
    }
  }


  //для самостоятельного изучения после ознакомления с extention - методами и интерфейсом IComparer
  static void BinaryListSearchingDemo() {
    //int size = 100;
    int size = 10_000_000;
    var sw = new Stopwatch();

    sw.Restart();
    var studList = Student.GetStudentList(Globals.StudentFileName, size);
    sw.Stop();
    WriteLine($"GetStudentList time: {sw.Elapsed}\n");

    sw.Restart();
    studList.Sort(Student.CompareByIIN);
    sw.Stop();
    WriteLine($"Sort time: {sw.Elapsed}\n");

    WriteLine("Search in List by our BinarySearch extention method:");
    string iInToFind = "270907618397";
    var studForSearch = new Student { IIN = iInToFind };
    sw.Restart();

    int idx = studList.BinarySearch(studForSearch, Student.CompareByIIN);
    //or with lambda:
    //int idx = studList.BinarySearch(studForSearch, (a, b) => a.IIN.CompareTo(b.IIN));
    sw.Stop();
    WriteLine($"BinarySearch time: {sw.Elapsed}\n");

    if (idx >= 0) {
      WriteLine($"{iInToFind} found at: {idx}");
      WriteLine(studList[idx]);
    } else {
      WriteLine("not found");
    }
  }




  public static void Demo() {
    SimpleBinarySearchDemo();
    //BinaryArraySearchingDemo();
    //BinaryListSearchingDemo();
  }
}

