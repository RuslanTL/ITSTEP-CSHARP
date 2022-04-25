global using static System.Console;

namespace StudentsNS {
  class Program {

    static void Main(string[] args) {
      try {
        //ComparisonDemo.Demo();
        //Sorting.Demo();
        Searching.Demo();

      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd . . .");
      ReadLine();
    }
  }
}
