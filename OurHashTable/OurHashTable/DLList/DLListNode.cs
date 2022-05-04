namespace DLListNS;
public class DLListNode<T> {
  public DLListNode(T value) {
    Value = value;
  }

  public T Value { get; internal set; }

  public DLListNode<T> Next { get; internal set; }

  public DLListNode<T> Previous { get; internal set; }
}

