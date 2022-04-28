namespace DemoNS;
delegate double SimpleFunc(double x);
//typedef double (*SimpleFunc)(double)  - in C++

delegate void SimpleVoid(string s);


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

}

