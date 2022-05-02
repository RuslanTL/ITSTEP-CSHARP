global using static System.Console;

namespace DemoNS;
class Program {
  static void Print(int deviceNumber, double oldValue, double newValue) {
    for (int i = 0; i < (deviceNumber - 1) * 10; i++) {
      Write(" ");
    }
    WriteLine($"{oldValue} -> {newValue}");
  }



  static void Demo() {
    Device device1 = new Device(1, 10);
    device1.ValueChanged += Print;

    Device device2 = new Device(2, 1000);
    device2.ValueChanged += Print;

    Thread thread1 = new Thread(device1.Run);
    Thread thread2 = new Thread(device2.Run);
    thread1.Start();
    thread2.Start();
    thread1.Join();
    thread2.Join();
  }



  static void Main(string[] args) {
    try {
      Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}

