using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DemoNS {
  class ObjectDemo {

    public static void Demo() {
      Stack stack = new Stack();
      stack.Push("cat");
      var s = (string)stack.Pop();
      Console.WriteLine(s);

      stack.Push(3);
      int three = (int)stack.Pop();
      Console.WriteLine(three);
    }
  }
}
