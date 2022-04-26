using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoNS {
  public class Point { public int X, Y; }

  class Program {


    static void Hello(Animal a) {
      //some work ...
      a.SayHello();
      //some work ...
    }


    static void HelloList(List<Animal> animals) {
      //some work ...
      foreach (var item in animals) {
        item.SayHello();
      }
      //some work ...
    }



    static void CastingDemo() {
      var b = new Bear { Name = "Pooh" };
      Animal a = b;
      WriteLine($"a: {a}");
      WriteLine($"a.Equals(b): {a.Equals(b)}");
      WriteLine($"a == b: {a == b}");
      WriteLine();

      Animal a2 = new Animal { Name = "Max" };
      //Bear b2 = a2; //compile error
      //Bear b2 = (Bear)a2; //runtime error

      Animal a3 = new Bear { Name = "Mischutka" };
      WriteLine($"Type: {a3.GetType().Name}");
      Bear b3 = (Bear)a3;
      WriteLine(a3);
      WriteLine(b3);
      WriteLine($"a3.Equals(b3): {a3.Equals(b3)}");
      WriteLine($"a3 == b3: {a3 == b3}");
    }



    static void AsIsDemo() {
      Animal a = new Animal { Name = "Max" };
      Bear b = a as Bear;
      if (b != null)
        WriteLine(b);
      else
        WriteLine("NULL");

      //or:
      if (a is Bear)
        WriteLine("Yes, I am Bear!");
      else
        WriteLine("No, I am not Bear!");

      WriteLine();


      Animal a2 = new Bear { Name = "Teddy;" };
      Bear b2 = a2 as Bear;
      if (b2 != null)
        WriteLine(b2);
      else
        WriteLine("NULL");

      //or:
      if (a2 is Bear)
        WriteLine("Yes, I am Bear!");
      else
        WriteLine("No, I am not Bear!");
    }



    static void MethodsDemo() {
      var a = new Animal() { Name = "Max" };
      a.InfoNonVirt();
      a.InfoVirt();
      WriteLine();

      var b = new Bear() { Name = "Pooh" };
      b.InfoNonVirt();
      b.InfoVirt();
      WriteLine();

      Animal aa = b;
      aa.InfoNonVirt();
      aa.InfoVirt();
      WriteLine();
    }



    static void MainPolymorphismIdeaDemo() {
      var a = new Animal();
      var b = new Bear();
      var c = new Cat();
      Hello(a); Hello(b); Hello(c);
      WriteLine();

      var animals = new List<Animal> { a, b, c };
      HelloList(animals);
    }



    static void AbstractsDemo() {
      Vehicle v;
      v = new Bus();
      v.Display();
      v = new Car(); 
      v.Display();
      v = new Motorcycle();
      v.Display();
    }



    static void ConstructorsDemo() {
      var sub = new Subclass(18, 60.5);
      Console.WriteLine(sub);
    }




    static void GetTypeDemo() {
      Point p = new Point();
      Console.WriteLine(p.GetType().Name);             // Point
      Console.WriteLine(typeof(Point).Name);           // Point
      Console.WriteLine(p.GetType() == typeof(Point)); // True
      Console.WriteLine(p.X.GetType().Name);           // Int32
      Console.WriteLine(p.Y.GetType().FullName);       // System.Int32
    }



    static void Main(string[] args) {
      try {
        //CastingDemo();
        //AsIsDemo();
        //MethodsDemo();
        //MainPolymorphismIdeaDemo();

        //AbstractsDemo();
        //ConstructorsDemo();
        ObjectDemo.Demo();
        //BoxingDemo.Demo();
        //GetTypeDemo();

      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd ...");
      ReadLine();
    }
  }
}
