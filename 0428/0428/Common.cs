using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0428 {

  static class Common {

    public static double Twice(double x) {
      return 2 * x;
    }


    public static double Sqware(double x) {
      return x * x;
    }


    public static double Half(double x) {
      return x / 2;
    }

    public static double Sqrt(double x) {
      return Math.Sqrt(x);
    }
    public static double Cube(double x) {
      return Math.Pow(x, 3);
    }
    public static double Log2(double x) {
      return Math.Log2(x);
    }
    public static double Log(double x, double _base) {
      return Math.Log(x, _base);
    }
  }
}
