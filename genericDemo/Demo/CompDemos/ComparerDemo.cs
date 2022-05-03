namespace ComparerDemoNS;
class ComparerDemo {

  class Comparer : IComparer<int> {
    public int Compare(int x, int y) {
      //return x > y ? -1 : x < y ? 1 : 0;
      //or:
      return -x.CompareTo(y);
    }
  }


  public static void Demo() {
    List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    var comparer = new Comparer();
    //public void Sort(IComparer<T> comparer);
    list.Sort(comparer);
    UtilsNS.Utils.PrintList(list);
  }
}

