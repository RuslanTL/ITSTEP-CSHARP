namespace InterfacesNS;
class Person : IComparable {
  public string Name { get; set; }
  public int Age { get; set; }


  public int CompareTo(object o) {
    Person p = o as Person;
    if (p != null) {
      //by Name:
      //return this.Name.CompareTo(p.Name);
      //by Age:
      //return this.Age.CompareTo(p.Age);

      //by Name-Age:
      int result = this.Name.CompareTo(p.Name);
      if (result != 0)
        return result;
      else
        return this.Age.CompareTo(p.Age);
    } else {
      throw new Exception("Невозможно сравнить два объекта");
    }
  }
}



class ComparableDemo {
  public static void Demo() {
    Person p1 = new Person { Name = "Bill", Age = 34 };
    Person p2 = new Person { Name = "Bill", Age = 20 };
    Person p3 = new Person { Name = "Tom", Age = 33 };
    Person p4 = new Person { Name = "Tom", Age = 31 };
    Person p5 = new Person { Name = "Tom", Age = 30 };
    Person p6 = new Person { Name = "Alice", Age = 21 };

    Person[] people = new Person[] { p1, p2, p3, p4, p5, p6 };
    Array.Sort(people);

    foreach (Person p in people) {
      WriteLine($"{p.Name} - {p.Age}");
    }
  }
}

