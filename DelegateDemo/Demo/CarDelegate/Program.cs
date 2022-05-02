global using static System.Console;

namespace CarDelegate;
class Program {
  public static void OnCarEngineEvent1(string msg) {
    WriteLine($"=> Speed: {msg}");
  }


  public static void OnCarEngineEvent2(string msg) {
    WriteLine($"=> Have a nice trip! Speed: {msg}");
  }



  static void Main(string[] args) {
    Car car = new Car("QuickAndDead", 120, 0);
    car.RegisterWithCarEngine(OnCarEngineEvent1);

    Car.CarEngineHandler handler2 = OnCarEngineEvent2;
    car.RegisterWithCarEngine(handler2);

    for (int i = 0; i < 40; i++) {
      car.Accelerate(5);
      if (car.Speed > 50)
        car.UnRegisterWithCarEngine(handler2);
    }

    WriteLine("\nEnd . . .");
    ReadLine();
  }
}
