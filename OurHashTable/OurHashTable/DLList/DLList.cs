namespace DLListNS;
public class DLList<T> {
  private DLListNode<T> _head;
  private DLListNode<T> _tail;

  public DLListNode<T> Head { get { return _head; } }

  public DLListNode<T> Tail { get { return _tail; } }


  public DLList(T value) {
    AddFirst(value);
  }


  public void AddFirst(T value) {
    DLListNode<T> node = new DLListNode<T>(value);

    // Save off the head node so we don't lose it
    DLListNode<T> temp = _head;

    // Point head to the new node
    _head = node;

    // Insert the rest of the list behind head
    _head.Next = temp;

    if (Count == 0) {
      // if the list was empty then head  and tail should
      // both point to the new node.
      _tail = _head;
    } else {
      // Before: head -------> 5 <-> 7 -> null
      // After:  head  -> 3 <-> 5 <-> 7 -> null
      temp.Previous = _head;
    }
    Count++;
  }


  public void AddLast(T value) {
    DLListNode<T> node = new DLListNode<T>(value);

    if (Count == 0) {
      _head = node;
    } else {
      _tail.Next = node;

      // Before: Head -> 3 <-> 5 -> null
      // After:  Head -> 3 <-> 5 <-> 7 -> null
      // 7.Previous = 5
      node.Previous = _tail;
    }
    _tail = node;
    Count++;
  }


  public void Add(T value) {
    AddLast(value);
  }


  public void Clear() {
    _head = null;
    _tail = null;
    Count = 0;
  }


  public bool Contains(T item) {
    DLListNode<T> current = _head;
    while (current != null) {
      if (current.Value.Equals(item)) {
        return true;
      }
      current = current.Next;
    }
    return false;
  }


  public void CopyTo(T[] array, int arrayIndex) {
    DLListNode<T> current = _head;
    while (current != null) {
      array[arrayIndex++] = current.Value;
      current = current.Next;
    }
  }


  public int Count {
    get;
    private set;
  }


  public void RemoveFirst() {
    if (Count != 0) {
      // Before: Head -> 3 <-> 5
      // After:  Head -------> 5

      // Head -> 3 -> null
      // Head ------> null
      _head = _head.Next;

      Count--;

      if (Count == 0) {
        _tail = null;
      } else {
        // 5.Previous was 3, now null
        _head.Previous = null;
      }
    }
  }


  public void RemoveLast() {
    if (Count != 0) {
      if (Count == 1) {
        _head = null;
        _tail = null;
      } else {
        // Before: Head --> 3 --> 5 --> 7
        //         Tail = 7
        // After:  Head --> 3 --> 5 --> null
        //         Tail = 5
        // Null out 5's Next pointerproperty
        _tail.Previous.Next = null;
        _tail = _tail.Previous;
      }
      Count--;
    }
  }


  public bool Remove(T item) {
    DLListNode<T> previous = null;
    DLListNode<T> current = _head;

    // 1: Empty list - do nothing
    // 2: Single node: (previous is null)
    // 3: Many nodes
    //    a: node to remove is the first node
    //    b: node to remove is the middle or last

    while (current != null) {
      // Head -> 3 -> 5 -> 7 -> null
      // Head -> 3 ------> 7 -> null
      if (current.Value.Equals(item)) {
        // it's a node in the middle or end
        if (previous != null) {
          // Case 3b
          previous.Next = current.Next;

          // it was the end - so update Tail
          if (current.Next == null) {
            _tail = previous;
          } else {
            // Before: Head -> 3 <-> 5 <-> 7 -> null
            // After:  Head -> 3 <-------> 7 -> null

            // previous = 3
            // current = 5
            // current.Next = 7
            // So... 7.Previous = 3
            current.Next.Previous = previous;
          }
          Count--;
        } else {
          // Case 2 or 3a
          RemoveFirst();
        }
        return true;
      }
      previous = current;
      current = current.Next;
    }
    return false;
  }



  public void Print() {
    var current = Head;
    while (current != null) {
      Console.Write($" -> {current.Value}");
      current = current.Next;
    }
    Console.WriteLine();
  }



  public string StringForPrint() {
    string result = "";
    var current = Head;
    while (current != null) {
      result += string.Format($" -> {current.Value}");
      current = current.Next;
    }
    return result;
  }
}

