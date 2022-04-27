namespace InterfacesNS;
interface I1 {
  void Foo();
}


interface I2 {
  int Foo();
  void Move();
}



public class Widget : I1, I2 {
  public void Foo() {
    WriteLine("Widget's implementation of I1.Foo");
  }


  int I2.Foo() {
    WriteLine("Widget's implementation of I2.Foo");
    return 42;
  }


  public void Move() {
    WriteLine("I am moving ...");
  }
}


class ExplicitAndMultyDemo {
  public static void Demo() {
    var widget = new Widget();
    widget.Foo();
    ((I1)widget).Foo();
    ((I2)widget).Foo();
    WriteLine();

    widget.Move();
    //or:
    I2 i2 = (I2)widget;
    i2.Move();
  }
}

