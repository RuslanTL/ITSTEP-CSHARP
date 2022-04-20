using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  class Program {

    static void Main(string[] args) {
      try {
        ExtentionsDemo.Demo();
        //OperatorOverloadingDemo.Demo();

      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd . . .");
      ReadLine();
    }
  }
}
