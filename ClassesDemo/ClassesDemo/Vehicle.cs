using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  public abstract class Vehicle {
    public abstract void Display();
  }


  public class Bus : Vehicle {
    public override void Display() {
      WriteLine("Bus");
    }
  }


  public class Car : Vehicle {
    public override void Display() {
      WriteLine("Car");
    }
  }


  public class Motorcycle : Vehicle {
    public override void Display() {
      WriteLine("Motorcycle");
    }
  }


}
