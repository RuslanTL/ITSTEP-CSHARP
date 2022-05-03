namespace ComparisonDemoNS;
class ComparisonDemo {

  public static void Demo() {
    List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    //public void Sort(Comparison<T> comparison);
    list.Sort((int x, int y) => -x.CompareTo(y));
    UtilsNS.Utils.PrintList(list);
  }
}


