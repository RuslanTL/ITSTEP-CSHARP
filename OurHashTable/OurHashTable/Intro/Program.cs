global using static System.Console;

namespace IntroNS;

class Program {

  static void HashTableDemo() {
    //int size = 1_000_000;
    int size = 100;
    int capacity = 1 * size;

    //comment - uncomment
    var arr = UtilsNS.Utils.GetRandomIntArray(size, -1000, 1000);
    //var arr = GetRandomIntArr(size, int.MinValue, int.MaxValue);

    var table = new HashLongTable(capacity);
    //HashTable<long> table = new HashTable<long>(capacity);

    foreach (var item in arr) {
      table.Add(item);
    }

    table.Print();
    WriteLine($"Содержит {table.Count} чисел из {size} ({(double)table.Count / size * 100,5:N2}%)");
  }



  static void SearchBenchmarkDemo() {
    //int size = 1_000_000;
    int size = 10_000_000;

    var arr = UtilsNS.Utils.GetRandomIntArray(size);
    //Benchmarks.SearchInUnsortedArrayTiming(arr);
    Benchmarks.SearchInOurHashTable(arr);
    Benchmarks.SearchInHashSet<int>(arr);
    Benchmarks.SearchBinaryInArray<int>(arr);
    Benchmarks.SearchOurBinaryInArray<int>(arr);

    //var doubleArr = UtilsNS.Utils.GetRandomDoubleArr(size);
    //Benchmarks.SearchInHashSet<double>(doubleArr);
  }


  public static void Main(string[] args) {
    HashTableDemo();
    SearchBenchmarkDemo();

    WriteLine("\nEnd . . .");
    ReadLine();
  }
}

