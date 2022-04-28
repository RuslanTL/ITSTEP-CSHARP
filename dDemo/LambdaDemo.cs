namespace DemoNS;

class LambdaDemo {

  public static void Demo() {
    SimpleFunc sqr = x => x * x / 2;
    WriteLine(sqr(3));

    // Using a statement block instead:
    SimpleFunc sqrBlock = x => { return x * x / 2; };
    WriteLine(sqr(3));

    // Using a generic System.Func delegate:
    Func<double, double> sqrFunc = x => x * x / 2;
    WriteLine(sqrFunc(3));

    // Using multiple arguments:
    Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
    int total = totalLength("Превед ", "Медвед!");
    WriteLine($"total = {total}");

    // Explicitly specifying parameter types:
    Func<double, double> sqrExplicit = (double x) => x * x / 2;
    WriteLine(sqrFunc(3));
  }
}

