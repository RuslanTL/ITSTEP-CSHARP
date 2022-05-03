namespace DemoNS;
class StackForObjects {
  public object[] data = new object[100];
  int top = -1;

  public void Push(object item) {
    data[++top] = item;
  }

  public object Pop() {
    if (top >= 0)
      return data[top--];
    else
      return 0;
  }


  public void Clear() {
    top = -1;
  }


  public void Print() {
    Console.WriteLine("Stack:");
    for (int i = top; i >= 0; i--) {
      Console.WriteLine($"{i}  {data[i]}");
    }
    Console.WriteLine("");
  }


  public static void Demo() {
    var stack = new StackForObjects();
    stack.Push(20.1); stack.Push("Превед"); stack.Push("Медвед"); stack.Push(4.2);
    stack.Print();
    Console.WriteLine();

    //double d = stack.Pop();
    double d = (double)stack.Pop();
    double d2 = (double)stack.Pop();
  }
}

