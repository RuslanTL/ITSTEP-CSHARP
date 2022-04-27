namespace InterfacesNS;

class Bear : IMovable {
  public void Move() {
    Console.WriteLine($"Bear is moving ...");
  }
}


class Cat : IMovable {
  public void Move() {
    Console.WriteLine($"Cat is moving ...");
  }
}


class Fox : IMovable {
  public void Move() {
    Console.WriteLine($"Fox is moving ...");
  }
}



class Man : IMovable {
  public void Move() {
    Console.WriteLine($"Man is moving ...");
  }
}


class Car : IMovable {
  public void Move() {
    Console.WriteLine($"Car is moving ...");
  }
}

