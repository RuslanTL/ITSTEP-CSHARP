namespace InterfacesNS;
class InterfaceDemo {

  static void MoveOne(IMovable movable) {
    movable.Move();
  }



  static void MoveAll(IMovable[] movableArr) {
    foreach (var item in movableArr) {
      item.Move();
    }
  }



  public static void Demo() {
    Bear b = new Bear();
    IMovable i = b;
    MoveOne(i);
    i = new Cat();
    MoveOne(i);
    WriteLine();

    MoveOne(new Bear());
    MoveOne(new Cat());
    MoveOne(new Fox());
    MoveOne(new Man());
    MoveOne(new Car());
    WriteLine();

    IMovable[] movableArr = { new Bear(), new Cat(), new Fox(), new Man(), new Car() };
    MoveAll(movableArr);
    WriteLine();

    //or
    IMovable i1 = new Bear();
    IMovable i2 = new Cat();
    IMovable i3 = new Fox();
    IMovable i4 = new Man();
    IMovable i5 = new Car();
    IMovable[] movableArr2 = { i1, i2, i3, i4, i5 };
    MoveAll(movableArr2);
    WriteLine();
  }
}

