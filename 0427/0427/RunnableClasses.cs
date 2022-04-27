using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0427 {
  /*В отдельном файле RunnaleClasses.cs создайте классы  Car, Track, Man, Bear, реализующие IRunnable.*/

  public class Bear : IRunnable {
    public double MaxSpeed { get; set; }
    public double Speed { get; set; }

    public Bear() {
      MaxSpeed = 40;
    }

    public void Run(double speed) {
      if (speed < MaxSpeed) { Speed = speed; } else { Speed = MaxSpeed; }
      Console.WriteLine($"{GetType().Name} is running at a speed of {Speed}");
    }
  }
  public class Car : IRunnable {
    public double MaxSpeed { get; set; }
    public double Speed { get; set; }

    public Car() {
      MaxSpeed = 100;
    }

    public void Run(double speed) {
      if (speed < MaxSpeed) { Speed = speed; } else { Speed = MaxSpeed; }
      Console.WriteLine($"{GetType().Name} is running at a speed of {Speed}");
    }
  }

  public class Truck : IRunnable {
    public double MaxSpeed { get; set; }
    public double Speed { get; set; }

    public Truck() {
      MaxSpeed = 90;
    }

    public void Run(double speed) {
      if (speed < MaxSpeed) { Speed = speed; } else { Speed = MaxSpeed; }
      Console.WriteLine($"{GetType().Name} is running at a speed of {Speed}");
    }
  }

  public class Man : IRunnable {
    public double MaxSpeed { get; set; }
    public double Speed { get; set; }

    public Man() {
      MaxSpeed = 20;
    }

    public void Run(double speed) {
      if (speed < MaxSpeed) { Speed = speed; } else { Speed = MaxSpeed; }
      Console.WriteLine($"{GetType().Name} is running at a speed of {Speed}");
    }
  }
}
