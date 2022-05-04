namespace HashDemoNS;
class HashDemo {
  public static void Demo() {
    int i, hash;
    long l;
    double d;

    WriteLine("int:");
    i = 10;
    hash = i.GetHashCode();
    WriteLine($"i = {i}, hash = {hash}");

    i = -10;
    hash = i.GetHashCode();
    WriteLine($"i = {i}, hash = {hash}");

    i = int.MaxValue;
    hash = i.GetHashCode();
    WriteLine($"i = {i}, hash = {hash}");

    i = int.MinValue;
    hash = i.GetHashCode();
    WriteLine($"i = {i}, hash = {hash}\n");

    WriteLine("long:");
    l = 10;
    hash = l.GetHashCode();
    WriteLine($"l = {l}, hash = {hash}");
    l = -10;
    hash = i.GetHashCode();
    WriteLine($"l = {l}, hash = {hash}\n");


    WriteLine("double:");
    d = 1;
    hash = d.GetHashCode();
    WriteLine($"d = {d}, hash = {hash}");

    d = -1.5;
    hash = d.GetHashCode();
    WriteLine($"d = {d}, hash = {hash}");

    d = Math.PI * 1_000_000;
    hash = d.GetHashCode();
    WriteLine($"d = {d}, hash = {hash}\n");

    WriteLine("Student:");
    var stud = new EquitableDemoNS.StudentClass { IIN = "000000000000", LastName = "Pooh" };
    hash = stud.GetHashCode();
    WriteLine($"stud: hash = {hash}\n");
  }
}

