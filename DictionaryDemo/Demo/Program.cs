global using static System.Console;

namespace DemoNS;
class Program {

  static void Main(string[] args) {
    try {
      CollectionsNS.DictionaryDemo.Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}
