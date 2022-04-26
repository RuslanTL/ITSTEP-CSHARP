using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*public abstract class Vehicle {
	public double MaxSpeed { get; set; }
	public double Speed { get; set; }
	public abstract void Run(double speed);
}

В классах - наследниках реализуйте:
Конструктор, в котором устанавливается разумная максимальная скорость MaxSpeed для данного типа.

Виртуальный метод, приводящий в движение транспортное средство, в том числе, задающий скорость Speed:
public override void Run(double speed) {
  //ограничьте скорость (не более MaxSpeed, учитывая тип автомобиля)
  //Speed = speed, если speed < MaxSpeed;   
  WriteLint($"( Car, Track, Bus, Motorcycle) движется со скоростью {Speed}");
}  

В static class VehicleDemo напишите методы:
public static void Run(List<Vehicle> autos, double speed)
public static double GetAverageSpeed(List<Vehicle> autos)

Создайте List<Vehicle> autos, содержащий автомобили разных типов.

Продемонстрируйте работу методов:
public static void Demo() {
	var autos = new List<Vehicle>() { new Car(), new Car(), new Truck(), new Bus(), new Motorcycle(), };
	
	Run(autos, 2000);
	WriteLine($"\nСредняя скорость = {GetAverageSpeed(autos)}\n");
	
	Run(autos, 70);
	WriteLine($"\nСредняя скорость = {GetAverageSpeed(autos)}\n");
}
*/

namespace _0426 {
	public abstract class Vehicle {
		public double MaxSpeed { get; set; }
		public double Speed { get; set; }
		public abstract void Run(double speed);
	}

	public class Car : Vehicle {
		public Car() {
			MaxSpeed = 100;
		}
		public override void Run(double speed) {
			//ограничьте скорость (не более MaxSpeed, учитывая тип автомобиля)
			//Speed = speed, если speed < MaxSpeed;   
			if (speed < MaxSpeed) {
				Speed = speed;
			} else {
				Speed = MaxSpeed;
			}
			Console.WriteLine($"Car движется со скоростью {Speed}");
		}
	}
	public class Truck : Vehicle {
		public Truck() {
			MaxSpeed = 80;
		}
		public override void Run(double speed) {
			//ограничьте скорость (не более MaxSpeed, учитывая тип автомобиля)
			//Speed = speed, если speed < MaxSpeed;   
			if (speed < MaxSpeed) {
				Speed = speed;
			} else {
				Speed = MaxSpeed;
			}
			Console.WriteLine($"Truck движется со скоростью {Speed}");
		}
	}

	public class Bus : Vehicle {
		public Bus() {
			MaxSpeed = 75;
		}
		public override void Run(double speed) {
			//ограничьте скорость (не более MaxSpeed, учитывая тип автомобиля)
			//Speed = speed, если speed < MaxSpeed;   
			if (speed < MaxSpeed) {
				Speed = speed;
			} else {
				Speed = MaxSpeed;
			}
			Console.WriteLine($"Bus движется со скоростью {Speed}");
		}
	}

	public class Motorcycle : Vehicle {
		public Motorcycle() {
			MaxSpeed = 120;
		}
		public override void Run(double speed) {
			//ограничьте скорость (не более MaxSpeed, учитывая тип автомобиля)
			//Speed = speed, если speed < MaxSpeed;   
			if (speed < MaxSpeed) {
				Speed = speed;
			} else {
				Speed = MaxSpeed;
			}
			Console.WriteLine($"Motorcycle движется со скоростью {Speed}");
		}
	}

	public static class VehicleDemo{
		public static void Run(List<Vehicle> autos, double speed) {
			Console.WriteLine($"Trying to set vehicles speed to {speed}...\n");
			foreach(var vehicle in autos) {
				vehicle.Run(speed);
      }
    }
		public static double GetAverageSpeed(List<Vehicle> autos) {
			double speedSum = 0;
			foreach(var vehicle in autos) {
				speedSum += vehicle.Speed;
      }
			return speedSum / autos.Count();
    }



	}

}
