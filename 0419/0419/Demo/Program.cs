using System;
using static System.Console;
using System.IO;
using System.Net;

namespace DemoNS {

  class Program {

    static void Main() {
      try {
        //Intro.Demo();
        //ThrowingDemo.Demo();
        FinallyDemo.Demo();
        //FullDemo.Demo();

        //OthersDemos.Demo();

      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd . . .");
      ReadLine();
    }
  }
}
