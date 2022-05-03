namespace DemoNS;
class StackGeneric<T> {
  public T[] data = new T[100];
  int top = -1;

  public void Push(T item) { data[++top] = item; }
  public T Pop() {
    if (top >= 0)
      return data[top--];
    else
      return default(T);
  }

  public void Clear() { top = -1; }


  public void Print() {
    Console.WriteLine("Stack generic:");
    for (int i = top; i >= 0; i--) {
      Console.WriteLine($"{i}  { data[i]}");
    }
    Console.WriteLine("");
  }
}



static class StackGenericDemo {
  public static void Demo() {
    var stack = new StackGeneric<int>();
    //stack.Push(20.1); stack.Push("qwerty"); stack.Push(2); stack.Push(4.2);
    stack.Push(20); stack.Push(4); stack.Push(2); stack.Push(6);
    stack.Print();
    Console.WriteLine();


    var stackStrings = new StackGeneric<string>();
    stackStrings.Push("20"); stackStrings.Push("Bear"); stackStrings.Push("Pooh"); stackStrings.Push("Winny");
    stackStrings.Print();
    Console.WriteLine();
  }
}

