namespace DemoNS;
class RealDemo {
  static double TransformAndSum(double[] arr, SimpleFunc f) {
    var result = 0.0;
    foreach (var item in arr) {
      result += f(item);
    }
    return result;
  }


  public static void Demo() {
    double[] arr = new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    double val;
    val = TransformAndSum(arr, Common.Twice);
    Console.WriteLine($"Twice sum = {val}");
    val = TransformAndSum(arr, Common.Sqware);
    Console.WriteLine($"Sqware sum = {val}");
    val = TransformAndSum(arr, Common.Half);
    Console.WriteLine($"Half sum = {val}");

    val = TransformAndSum(arr, (x) => x + Math.Sin(x) + 1000);
    Console.WriteLine($"Any = {val}");
  }

}

