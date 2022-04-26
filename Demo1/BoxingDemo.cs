using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  class BoxingDemo {
    public static void Demo() {
      int x = 9;
      object obj = x;     // box the int
      Console.WriteLine(obj);

      int y = (int)obj;   // unbox the int
      Console.WriteLine(y);


      int i = 3;
      object boxed = i;
      i = 5;
      Console.WriteLine(boxed);    // 3

    }
  }
}
