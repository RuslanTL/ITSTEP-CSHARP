namespace EquitableDemoNS;
//There are two kinds of equality:
//  Value equality
//    Two values are equivalent in some sense.
//  Referential equality
//    Two references refer to exactly the same object.
//
//Unless overridden:
//  Value types use value equality.
//  Reference types use referential equality


class EquitableDemo {

  static void Operators_Demo() {
    //== and != are statically resolved(in fact, they are implemented as static functions).
    //So, when you use == or !=, C# makes a compile-time decision as to which type will perform the comparison,
    //and no virtual behavior comes into play.

    //Reference types:
    WriteLine("Reference types:");
    var studClass1 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    var studClass2 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    var studClass3 = studClass1;
    WriteLine($"studClass1 == studClass2: {studClass1 == studClass2}");
    WriteLine($"studClass1 == studClass3: {studClass1 == studClass3}");
    WriteLine();

    object x = 5;
    object y = 5;
    WriteLine(x == y);
    WriteLine();

    //but for strings (== overloaded):
    WriteLine("Strings:");
    string s1 = "hello";
    string s2 = new string(s1);

    string s3 = s1;
    WriteLine($"s1 == s2: {s1 == s2}");
    WriteLine($"s1 == s3: {s1 == s3}");
    //but:
    WriteLine($"object.ReferenceEquals(s1, s2): {object.ReferenceEquals(s1, s2)}");
    WriteLine($"object.ReferenceEquals(s1, s3): {object.ReferenceEquals(s1, s3)}");
    WriteLine();


    //Value types:
    WriteLine("Value types:");
    int i = 2, j = 2;
    WriteLine($"i == j: {i == j}");

    // comment overloaded == and !=
    var studStruct1 = new StudentStruct { IIN = "000000000000", LastName = "Pooh" };
    var studStruct2 = new StudentStruct { IIN = "000000000000", LastName = "Pooh" };
    WriteLine($"studStruct1 == studStruct2: {studStruct1 == studStruct2}");
  }



  static void Object_Virtual_Equals_Demo() {
    //Reference types:
    WriteLine("Reference types:");
    var studClass1 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    var studClass2 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    var studClass3 = studClass1;
    WriteLine($"studClass1.Equals(studClass2): {studClass1.Equals(studClass2)}");
    WriteLine($"studClass1.Equals(studClass3): {studClass1.Equals(studClass3)}");
    WriteLine();

    object x = 5;
    object y = 5;
    WriteLine($"x.Equals(y): {x.Equals(y)}");
    WriteLine();


    //Value types:
    WriteLine("Value types:");
    int i = 2, j = 2;
    WriteLine($"i.Equals(j): {i.Equals(j)}");


    var studStruct1 = new StudentStruct { IIN = "000000000000", LastName = "Pooh" };
    var studStruct2 = new StudentStruct { IIN = "000000000000", LastName = "Pooh" };
    WriteLine($"studStruct1.Equals(studStruct2): {studStruct1.Equals(studStruct2)}");

    //Equals полезен в generic типах, где нельзя пользоваться == и != !!!
  }



  static void Object_Static_Equals_Demo() {
    //Делает проверку на null и вызывает virtual Equals для сравниваемых объектов
    var studClass1 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    var studClass2 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    var studClass3 = studClass1;
    WriteLine($"object.Equals(studClass1, studClass2): {object.Equals(studClass1, studClass2)}");
    WriteLine($"object.Equals(studClass1, studClass3): {object.Equals(studClass1, studClass3)}");
    WriteLine();
    //object.Equals полезен в generic типах, где нельзя пользоваться == и != !!!
  }



  static void Object_Static_Reference_Equals() {
    //Forces referential equality comparison!
    //Используется если перегружены virtual Equals и == !

    var studClass1 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    var studClass2 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    var studClass3 = studClass1;
    WriteLine($"object.ReferenceEquals(studClass1, studClass2): {object.ReferenceEquals(studClass1, studClass2)}");
    WriteLine($"object.ReferenceEquals(studClass1, studClass3): {object.ReferenceEquals(studClass1, studClass3)}");
    WriteLine();

    var studStruct1 = new StudentStruct { IIN = "000000000000", LastName = "Pooh" };
    var studStruct2 = new StudentStruct { IIN = "000000000000", LastName = "Pooh" };
    WriteLine($"object.ReferenceEquals(studStruct1, studStruct2): {object.ReferenceEquals(studStruct1, studStruct2)}"); //boxing!
  }



  class Test<T> where T : IEquatable<T> {
    public bool IsEqual(T a, T b) {
      return a.Equals(b); // No boxing with generic T
    }
  }



  static void IEquatableDemo() {
    //The idea is that IEquatable <T>, when implemented, gives the same result as calling
    //object’s virtual Equals method — but more quickly.
    //Most basic .NET types implement IEquatable<T>.
    //You can use IEquatable<T> as a constraint in a generic type (see Test)
    //var studClass1 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    //var studClass2 = new StudentClass { IIN = "000000000000", LastName = "Pooh" };
    //to do ...
  }



  public static void Demo() {
    Operators_Demo();
    Object_Virtual_Equals_Demo();
    Object_Static_Equals_Demo();
    Object_Static_Reference_Equals();

    //IEquatableDemo();
  }

}

