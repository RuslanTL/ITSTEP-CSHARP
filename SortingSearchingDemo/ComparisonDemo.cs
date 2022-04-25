namespace StudentsNS;
class ComparisonDemo {
  public static void Demo() {
    int a = 1, b = 2, c = -3;
    WriteLine($"a = {a}, b = {b}, c = {c}\n");
    WriteLine($"a.CompareTo(b) = {a.CompareTo(b)}");
    WriteLine($"a.CompareTo(c) = {a.CompareTo(c)}");
    WriteLine($"a.CompareTo(1) = {a.CompareTo(1)}\n");

    string bear = "bear";
    string cat = "cat";
    WriteLine($"bear.CompareTo(cat) = {bear.CompareTo(cat)}");
  }
}
