using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNS {
  public class Calculator {
    public static int CalcInt(int x) { return 10 / x; }
    public static double CalcDouble(double x) {
      if (x == 0.0)
        throw new Exception("Авария!!");
      return 10.0 / x;
    }
  }
}
