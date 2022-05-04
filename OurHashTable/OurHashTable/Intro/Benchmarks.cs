using System.Diagnostics;

namespace IntroNS;
class Benchmarks {

  public static int OurBynarySearch<T>(T[] arr, T value) where T : IComparable<T> {
    int min = 0;
    int max = arr.Length - 1;
    while (min <= max) {
      int mid = min + ((max - min) / 2);
      if (value.Equals(arr[mid])) {
        return mid;
      } else if (value.CompareTo(arr[mid]) < 0) {
        max = mid - 1;
      } else {
        min = mid + 1;
      }
    }
    return -1;
  }



  static public void SearchInUnsortedArrayTiming(int[] arr) {
    int nFound = 0;
    int size = arr.Length;
    var sw = new Stopwatch();
    sw.Restart();
    foreach (var item in arr) {
      for (int i = 0; i < size; i++) {
        if (item == arr[i]) {
          nFound++;
          break;
        }
      }
    }
    sw.Stop();
    WriteLine($"Search in unsorted array:");
    WriteLine($"found: {nFound}");
    WriteLine($"Time elapsed: {sw.Elapsed}\n");
    WriteLine();
  }



  static public void SearchInOurHashTable(int[] arr) {
    int size = arr.Length;
    int capacity = 1 * size;
    int nFound = 0;
    HashLongTable table = new HashLongTable(capacity);
    //HashTable<long> table = new HashTable<long>(capacity);
    foreach (var item in arr) {
      table.Add(item);
    }
    var sw = new Stopwatch();
    sw.Restart();
    nFound = 0;
    foreach (var item in arr) {
      if (table.Contains(item))
        nFound++;
    }
    sw.Stop();
    WriteLine($"Search in our hash table:");
    WriteLine($"found: {nFound}");
    WriteLine($"Time elapsed: {sw.Elapsed}\n");
  }



  static public void SearchInHashSet<T>(T[] arr) {
    int size = arr.Length;
    int capacity = 1 * size;
    int nFound = 0;
    HashSet<T> hashSet = new HashSet<T>(capacity);
    foreach (var item in arr) {
      hashSet.Add(item);
    }
    var sw = new Stopwatch();
    sw.Restart();
    nFound = 0;
    foreach (var item in arr) {
      if (hashSet.Contains(item))
        nFound++;
    }
    sw.Stop();
    WriteLine($"Search in HashSet:");
    WriteLine($"found: {nFound}");
    WriteLine($"Time elapsed: {sw.Elapsed}\n");
  }



  static public void SearchBinaryInArray<T>(T[] arrOrigin) {
    int size = arrOrigin.Length;
    T[] arr = new T[size];
    Array.Copy(arrOrigin, arr, size);
    Array.Sort(arr);
    int nFound = 0;

    var sw = new Stopwatch();
    sw.Restart();
    nFound = 0;
    //arr[0] = default(T); //for check!
    foreach (var item in arrOrigin) {
      if (Array.BinarySearch<T>(arr, item) >= 0)
        nFound++;
    }
    sw.Stop();
    WriteLine($"Search binary in array:");
    WriteLine($"found: {nFound}");
    WriteLine($"Time elapsed: {sw.Elapsed}\n");
  }


  static public void SearchOurBinaryInArray<T>(T[] arrOrigin) where T : IComparable<T> {
    int size = arrOrigin.Length;
    T[] arr = new T[size];
    Array.Copy(arrOrigin, arr, size);
    Array.Sort(arr);
    int nFound = 0;

    var sw = new Stopwatch();
    sw.Restart();
    nFound = 0;
    foreach (var item in arrOrigin) {
      if (OurBynarySearch<T>(arr, item) >= 0)
        nFound++;
    }
    sw.Stop();
    WriteLine($"Search our binary in array:");
    WriteLine($"found: {nFound}");
    WriteLine($"Time elapsed: {sw.Elapsed}\n");
  }
}

