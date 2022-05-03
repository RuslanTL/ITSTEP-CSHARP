namespace DemoNS;
class StackForDoubles {
  public double[] data = new double[100];
  int top = -1;

  public void Push(double item) {
    data[++top] = item;
  }

  public double Pop() {
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
      Console.WriteLine($"{i}  {data[i],5:N2}");
    }
    Console.WriteLine("");
  }


  public static void Demo() {
    var stack = new StackForDoubles();
    stack.Push(20.1); stack.Push(0); stack.Push(2); stack.Push(4.2);
    stack.Print();
    Console.WriteLine();
  }
}

