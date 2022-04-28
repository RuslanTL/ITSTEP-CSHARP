namespace DemoNS;
public delegate void ProgressReporter(int percentComplete);


class X {
  public double Divider;
  public void InstanceProgress(int percentComplete) {
    WriteLine(percentComplete / Divider);
  }
}



class InstanceMethodsDemo {

  static public void Demo() {
    X x = new X() { Divider = 2 };
    ProgressReporter p = x.InstanceProgress;
    p(99);
    WriteLine(p.Target == x);
    //p.Target is null for static methods!
    WriteLine(p.Method);
  }
}
