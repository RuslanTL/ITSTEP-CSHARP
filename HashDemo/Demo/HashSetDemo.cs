namespace HashSetDemoNS;
class HashSetDemo {

  public static void Demo() {
    int size = 1_000_000;
    var rnd = new Random();
    var hashSet = new HashSet<long>();
    for (int i = 0; i < size; i++) {
      hashSet.Add(rnd.Next(-1000, 1000));
    }

    int count = hashSet.Count;
    WriteLine($"count = {count}");

    bool found;
    found = hashSet.Contains(999);
    WriteLine($"999 found: {found}");
    found = hashSet.Contains(1000);
    WriteLine($"1000 found: {found}");
  }
}

