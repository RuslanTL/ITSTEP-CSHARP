namespace DemoNS;
delegate void StringAction(string s);


class ContrvarianceDemo {
  static void ActOnObject(object o) {
    Console.WriteLine(o);
  }


  static public void Demo() {
    StringAction sa = new StringAction(ActOnObject);
    sa("hello");
  }
}

