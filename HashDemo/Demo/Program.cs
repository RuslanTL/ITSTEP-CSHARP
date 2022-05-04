global using static System.Console;

namespace DemoNS;

class Program {
  static void Main(string[] args) {
    try {
      //EquitableDemoNS.EquitableDemo.Demo();
      //HashDemoNS.HashDemo.Demo();
      HashSetDemoNS.HashSetDemo.Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}

