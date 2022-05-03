namespace GenericsDemoNS;

class Util {
  public static void Swap<T>(ref T a, ref T b) {
    T temp = a;
    a = b;
    b = temp;
  }
}



class SomeClass {
  public int X = 1;
  public int Y = 1;

  public SomeClass() { }

  public SomeClass(int x, int y) { X = x; Y = y; }

  public override string ToString() {
    return $"X = {X}, Y = {Y}";
  }
}



struct SomeStruct {
  public int X;
  public int Y;

  public override string ToString() {
    return $"X = {X}, Y = {Y}";
  }
}




class Stack<T> {
  public T[] data = new T[100];
  int top = -1;

  public void Push(T obj) { data[++top] = obj; }
  public T Pop() {
    if (top >= 0)
      return data[top--];
    else
      return default(T);
  }

  public void Clear() { top = -1; }


  public virtual void Print() {
    WriteLine("Stack:");
    for (int i = top; i >= 0; i--) {
      WriteLine($"{i} - {data[i]}");
    }
    WriteLine();
  }
}



class StackAndAllAllAll<T, U> : Stack<T> where T : IComparable<T> where U : new() {
  public U Value;

  public StackAndAllAllAll(U value) {
    Value = value;
    // часто используется:
    // _value = default(U);
  }


  public void SwapFirstTwo() {
    if (data[0].CompareTo(data[1]) > 0)
      Util.Swap(ref data[0], ref data[1]);
  }


  public override void Print() {
    base.Print();
    Console.WriteLine($"Value: {Value}\n");
  }
}



class GenericsDemo {

  static void SwapDemo() {
    int i = 1, j = 2;
    Console.WriteLine($"i = {i}, j = {j}");
    Util.Swap<int>(ref i, ref j);
    Console.WriteLine($"i = {i}, j = {j}");

    string s1 = "Hello", s2 = "Dolly";
    Console.WriteLine($"{s1}, {s2}");
    Util.Swap<string>(ref s1, ref s2);
    Console.WriteLine($"{s1}, {s2}");
  }


  static void StackDemoWithClass() {
    var someClass = new SomeClass(10, 20);
    var stackSomeClass = new StackAndAllAllAll<int, SomeClass>(someClass);
    stackSomeClass.Push(10); stackSomeClass.Push(0); stackSomeClass.Push(20); stackSomeClass.Push(30);
    stackSomeClass.Print();
    WriteLine();
    stackSomeClass.SwapFirstTwo();
    stackSomeClass.Print();
    WriteLine();
    int i = stackSomeClass.Pop();
    i = stackSomeClass.Pop();
    stackSomeClass.Print();
  }



  public static void StackDemoWithStruct() {
    var someStruct = new SomeStruct();
    someStruct.X = 100; someStruct.Y = 200;
    var stackSomeStruct = new StackAndAllAllAll<int, SomeStruct>(someStruct);
    stackSomeStruct.Push(100); stackSomeStruct.Push(0); stackSomeStruct.Push(200); stackSomeStruct.Push(300);
    stackSomeStruct.Print();
    WriteLine();
    stackSomeStruct.SwapFirstTwo();
    stackSomeStruct.Print();
    WriteLine();
    int i = stackSomeStruct.Pop();
    i = stackSomeStruct.Pop();
    stackSomeStruct.Print();
  }



  static void StackDemo() {
    StackDemoWithClass();
    StackDemoWithStruct();
  }



  public static void Demo() {
    SwapDemo();
    StackDemo();
  }
}
