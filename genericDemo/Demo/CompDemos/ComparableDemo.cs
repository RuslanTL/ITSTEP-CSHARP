namespace ComparableDemoNS;
class ComparableDemo {
  static (T min, T max) GetMinMax<T>(T a, T b) where T : IComparable<T> {
    T min, max;
    if (a.CompareTo(b) < 0) {
      min = a;
      max = b;
    } else {
      min = b;
      max = a;
    }
    return (min, max);
  }




  public static void Demo() {
    int min, max;
    (min, max) = GetMinMax<int>(4, -3);
    Console.WriteLine($"min = {min}, max = {max}");
    Console.WriteLine();

    string minStr, maxStr;
    (minStr, maxStr) = GetMinMax<string>("Hello", "Pooh");
    Console.WriteLine($"min = {minStr}, max = {maxStr}");


    List<int> list = new List<int>() { 2, 1, 0, 3, 4, 5, 6, 7, 8, 9 };
    list.Sort();
    UtilsNS.Utils.PrintList(list);


    List<Bear> bearList = new List<Bear>() {
        new Bear() {Name = "Winny" },
        new Bear() { Name = "Potap" },
        new Bear() { Name = "Mishutka" }
      };

    bearList.Sort();
    UtilsNS.Utils.PrintList(bearList);
    //the same as:
    Comparer<Bear> defaultBearComp = Comparer<Bear>.Default;
    bearList.Sort(defaultBearComp);
    UtilsNS.Utils.PrintList(bearList);


    List<Cat> catList = new List<Cat>() {
        new Cat() {Name = "Tom" },
        new Cat() { Name = "Barsick" }
      };

    catList.Sort();
    UtilsNS.Utils.PrintList(catList); //runtime error!
  }
}



class Bear : IComparable<Bear> {
  public string Name { get; set; }

  public override string ToString() {
    return Name;
  }

  public int CompareTo(Bear other) {
    return Name.CompareTo(other.Name);
  }
}



class Cat {
  public string Name { get; set; }

  public override string ToString() {
    return Name;
  }
}


