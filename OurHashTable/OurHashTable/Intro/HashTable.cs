using DLListNS;

namespace IntroNS {

  public class HashTable<T> {
    struct Bucket {
      public DLList<T> List;
    }


    int _capacity;
    Bucket[] _table;


    public HashTable(int capacity) {
      _capacity = capacity;
      _table = new Bucket[capacity];
    }


    private static int GetHash(T value) {
      return Math.Abs(value.GetHashCode());
    }


    public int Count { get; private set; }


    public bool Contains(T value) {
      int idx = GetHash(value) % _capacity;
      var list = _table[idx].List;
      if (list != null) {
        return list.Contains(value);
      } else {
        return false;
      }
    }


    public bool Add(T value) {
      if (Contains(value))
        return false;
      int idx = GetHash(value) % _capacity;
      if (_table[idx].List != null)
        _table[idx].List.AddLast(value);
      else
        _table[idx].List = new DLList<T>(value);
      Count++;
      return true;
    }


    public void Remove(T value) {
      int idx = GetHash(value) % _capacity;
      var list = _table[idx].List;
      if (list != null) {
        if (list.Remove(value))
          Count--;
      }
    }


    public void Print() {
      for (int i = 0; i < _capacity; i++) {
        var list = _table[i].List;
        bool contains = list != null;
        Console.WriteLine($"{i, 6} {i.GetHashCode() % _capacity, 6} {contains, 6} {list?.StringForPrint(), 12}");
      }
    }
  }
}