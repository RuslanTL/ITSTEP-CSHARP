namespace DemoNS;

class PathDemo {
  public static void Demo() {
    string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
    WriteLine(baseFolder);
    WriteLine();

    string exePath1 = Path.Combine(baseFolder, "demo.exe");

    WriteLine(exePath1);
    WriteLine(File.Exists(exePath1));
    WriteLine();

    WriteLine(Path.Combine(@"C:\_0", "students_10_000_000.txt"));
    WriteLine(Path.Combine(@"C:\_0\", "students_10_000_000.txt"));
    WriteLine(Path.Combine(@"C:\", @"_0\", "students_10_000_000.txt"));
    WriteLine(Path.Combine(@"C:", @"_0", "students_10_000_000.txt"));
  }
}

