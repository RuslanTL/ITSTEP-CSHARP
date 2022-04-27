using System.Collections;

namespace InterfacesNS.IComparerNS;
class Person {
  public string Name { get; set; }
  public int Age { get; set; }
}



class PeopleComparer : IComparer {
  public int Compare(object o1, object o2) {
    Person p1 = o1 as Person;
    Person p2 = o2 as Person;
    //by length of name:
    //if (p1.Name.Length > p2.Name.Length)
    //  return 1;
    //else if (p1.Name.Length < p2.Name.Length)
    //  return -1;
    //else
    //  return 0;

    //by Name-Age:
    int result = p1.Name.CompareTo(p2.Name);
    if (result != 0)
      return result;
    else
      return p1.Age.CompareTo(p2.Age);
  }
}




class ComparerDemo {
  static public void Demo() {
    Person p1 = new Person { Name = "Bill", Age = 34 };
    Person p2 = new Person { Name = "Bill", Age = 20 };
    Person p3 = new Person { Name = "Tom", Age = 33 };
    Person p4 = new Person { Name = "Tom", Age = 31 };
    Person p5 = new Person { Name = "Tom", Age = 30 };
    Person p6 = new Person { Name = "Alice", Age = 21 };

    Person[] people = new Person[] { p1, p2, p3, p4, p5, p6 };
    Array.Sort(people, new PeopleComparer());

    foreach (Person p in people) {
      Console.WriteLine($"{p.Name} - {p.Age}");
    }
  }
}

