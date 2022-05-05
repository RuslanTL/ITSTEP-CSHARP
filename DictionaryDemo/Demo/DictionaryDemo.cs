namespace CollectionsNS;
class DictionaryDemo {

  static Dictionary<int, string> GetDictionary() {
    var dict = new Dictionary<int, string>() {
        {1, "Bear" },
        {2, "Cat" },
        {3, "Fox" },
        {25, "Bear" },
        {30, "Wolf" },
        {4, "Dog" },
      };
    return dict;
  }



  public static void AddReadWriteDemo() {
    var dict = GetDictionary();
    dict.Add(5, "Fox");
    //or
    dict[6] = "Kitten";

    foreach (var item in dict) {
      WriteLine($"{item.Key} - {item.Value}");
    }
    WriteLine();

    var a = dict[2];
    WriteLine($"{a}\n");

    dict[2] = "Other cat";
    //WriteLine(dict[22]); //runtime error
    dict[22] = "Other bear";
    WriteLine(dict[22]);

    foreach (var item in dict) {
      WriteLine($"{item.Key} - {item.Value}");
    }
    WriteLine();

    //var sss  = dict[300];
    if (dict.TryGetValue(300, out string s))
      WriteLine($"s = {s}\n");
    else
      WriteLine("нет ничиво!");

    //dict[1] = "Cat";
    bool res = dict.TryAdd(1, "Cat");
    if (res)
      WriteLine("Added");
    else
      WriteLine("Add error!");
  }




  public static void AdvancedDemo() {
    var dict = GetDictionary();
    bool isContains;
    var keys = dict.Keys;
    WriteLine($"keys.Count = {keys.Count}");
    foreach (var key in keys) {
      WriteLine(key);
    }
    WriteLine();

    var values = dict.Values;
    WriteLine($"values.Count = {values.Count}");
    foreach (var value in values) {
      WriteLine(value);
    }
    WriteLine();

    isContains = dict.ContainsKey(1);
    WriteLine($"{isContains}");
    isContains = dict.ContainsValue("Bear");
    WriteLine($"{isContains}\n");


    //List<KeyValuePair<string, int>> list = Dict.ToList();
    var list = dict.ToList();
    foreach (var item in list) {
      WriteLine($"{item.Key} - {item.Value}");
    }
    WriteLine();

    WriteLine("sorted by key:");
    list.Sort((a, b) => a.Key.CompareTo(b.Key));
    foreach (var item in list) {
      WriteLine($"{item.Key} - {item.Value}");
    }
    WriteLine();

    WriteLine("sorted by value:");
    list.Sort((a, b) => a.Value.CompareTo(b.Value));
    foreach (var item in list) {
      WriteLine($"{item.Key} - {item.Value}");
    }
    WriteLine();
  }



  public static void Demo() {
    AddReadWriteDemo();
    AdvancedDemo();
  }
}

