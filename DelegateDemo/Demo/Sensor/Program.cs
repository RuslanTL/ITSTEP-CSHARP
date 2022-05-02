global using static System.Console;

namespace SensorNS;

delegate void AlarmHandler();
//or can use Action()! 

class Sensor {
  public event AlarmHandler HighTemp;
  public event AlarmHandler LowTemp;

  readonly double _tempMin = -5;
  readonly double _tempMax = 15;

  double _temperature;

  public double Temperature {
    get { return _temperature; }
    set {
      _temperature = value;
      if (value > _tempMax) {
        if (HighTemp != null) {
          HighTemp();
        }
      }
      if (value < _tempMin) {
        if (LowTemp != null) {
          LowTemp();
        }
      }
    }
  }

}



class Program {
  static void Main(string[] args) {
    var sensor = new Sensor();
    sensor.HighTemp += () => { Console.WriteLine("Медвед проснулся! Превед, Медвед! "); };
    sensor.LowTemp += () => { Console.WriteLine("Медвед заснул . . ."); };

    Random rnd = new Random();
    for (int i = 0; i < 50; i++) {
      double temp = rnd.Next(-40, 40);
      Console.WriteLine($"\n{temp}");
      sensor.Temperature = temp;
      Thread.Sleep(100);
    }
    Console.WriteLine("\nEnd . . .");
    Console.ReadLine();
  }
}

