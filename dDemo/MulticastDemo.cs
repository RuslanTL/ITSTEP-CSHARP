namespace DemoNS;
class MulticastDemo {
  public static void Demo() {
    Action<string> engHello = (x) => Console.WriteLine($"Hello {x}!");
    Action<string> rusHello = (x) => Console.WriteLine($"Превед {x}!");
    var sum = engHello + rusHello;
    sum("Медвед");
    Console.WriteLine();

    var substr = sum - engHello;
    substr("Медвед");
    Console.WriteLine();

    //return;

    //or:
    Action<string> del = null;
    del += engHello;
    del("Pooh");
    Console.WriteLine();
    del += rusHello;
    del("Pooh");
    Console.WriteLine();
    del -= engHello;
    del("Pooh");
  }
}

