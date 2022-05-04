using DLListNS;

namespace IntroNS;

public class HashLongTable {
  struct Bucket {
    public DLList<long> List;
  }


  int _capacity;
  Bucket[] _table;


  public HashLongTable(int capacity) {
    _capacity = capacity;
    _table = new Bucket[capacity];
  }


  private static int GetHash(long value) {
    return Math.Abs((int)value);

    //or:
    //return Math.Abs(value.GetHashCode());
  }


  public int Count { get; private set; }


  public bool Contains(long value) {
    int idx = GetHash(value) % _capacity;
    var list = _table[idx].List;
    if (list != null) {
      return list.Contains(value);
    } else {
      return false;
    }
  }


  public bool Add(long value) {
    if (Contains(value))
      return false;
    int idx = GetHash(value) % _capacity;
    if (_table[idx].List != null)
      _table[idx].List.AddLast(value);
    else
      _table[idx].List = new DLList<long>(value);
    Count++;
    return true;
  }


  public void Remove(long value) {
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
      Console.WriteLine($"{i,2} {GetHash(i) % _capacity,6} {contains,6} {list?.StringForPrint(),12}");
    }
  }
}
