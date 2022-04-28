namespace DemoNS;
class InterfaceInsteadOfDelegateDemo {

  interface ISimpleFunc {
    double SimpleFunc(double x);
  }



  class Square : ISimpleFunc {
    public double SimpleFunc(double x) {
      return x * x;
    }
  }



  class Sin : ISimpleFunc {
    public double SimpleFunc(double x) {
      return Math.Sin(x);
    }
  }



  static double TransformByInterface(double[] arr, ISimpleFunc interf) {
    var result = 0.0;
    foreach (var item in arr) {
      result += interf.SimpleFunc(item);
    }
    return result;
  }


  public static void Demo() {
    var f = new Square();
    double[] arr = new double[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
    double val;
    val = TransformByInterface(arr, f);
    WriteLine("Square sum by interface = {0}", val);

    var f2 = new Sin();
    val = TransformByInterface(arr, f2);
    WriteLine("Sin sum by interface = {0}", val);
  }
}


