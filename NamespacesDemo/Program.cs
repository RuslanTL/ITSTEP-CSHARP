global using static System.Console;
using static System.Math;

using MyLib1NS;
using static MyLib2NS.MyLib2;
using NestedOuter.NestedInner;


namespace NamespacesNS {
  //or simply:
  //namespace NamespacesNS;

  class Program {

    static void FullNames() {
      MyLib1NS.MyLib1.PrintString();
      MyLib2NS.MyLib2.PrintString();
    }



    static void UsingDemo() {
      MyLib1.PrintString();
      MyLib2NS.MyLib2.PrintString();
    }



    static void UsingStaticDemo() {
      MyLib1.PrintString();
      PrintString();

      var x = Math.Sin(1);

      //with using static System.Math;
      var y = Sin(1);
      Console.WriteLine($"x = {x:N2}; y = {y:N2}");

      //with using static System.Console:
      WriteLine($"x = {x:N2}; y = {y:N2}");
    }



    static void NestedDemo() {
      var o1 = new NestedOuter.NestedInner.MyClass() { IIN = 123 };
      Console.WriteLine(o1.IIN);

      //or (with using):
      var o2 = new MyClass() { IIN = 456 };
      Console.WriteLine(o2.IIN);
    }



    static void Main(string[] args) {
      FullNames();
      //UsingDemo();
      //UsingStaticDemo();
      //NestedDemo();

      Console.ReadLine();
    }
  }
}
