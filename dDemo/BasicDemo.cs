namespace DemoNS;
class BasicDemo {

  public static void Demo() {
    SimpleFunc func = Common.Twice;
    WriteLine($"Twice(4) = {func(4)}");
    //or simply lambda
    SimpleFunc func2 = x => 2 * x;
    WriteLine($"Twice(4) = {func2(4)}");

    //or - old style
    SimpleFunc func3 = new SimpleFunc(Common.Sqware);
    WriteLine($"Sqware(16) = {func3(16)}");
    WriteLine();

    //new style:
    Func<double, double> func4 = Common.Twice;
    WriteLine($"Twice(4) = {func4(4)}");
    //or simply lambda:
    Func<double, double> func5 = x => 2 * x;
    WriteLine($"Twice(4) = {func5(4)}");
    WriteLine();

    //The Func and Action Delegates:

    //delegate TResult Func<TResult> ();
    Func<double> f0 = () => Math.PI / 4;

    //delegate TResult Func<T, TResult>(T arg);
    Func<double, string> f1 = (x) => $"value of x = {x}";

    //delegate TResult Func<T1, T2, TResult> (T1 arg1, T2 arg2);
    Func<string, double, double> f2 = (s, x) => { return double.Parse(s) + x; };

    //delegate void Action();
    Action a0 = () => Console.WriteLine("Hello!");

    //delegate void Action<in T>(T arg);
    Action<string> a1 = (s) => Console.WriteLine($"Hello {s}!");

    //delegate void Action<in T1, T2>(T1 arg1, T2 arg2);
    Action<string, double> act = (s, x) => { WriteLine($"Hello {s}! Get ${x * x}!"); };
    act("Медвед", 10);
  }
}
