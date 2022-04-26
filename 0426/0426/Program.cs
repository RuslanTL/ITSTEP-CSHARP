using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 01 - Vehicles
Создайте абстрастный класс Vehicle (транспортное средство) с наследниками Car, Track, Bus, Motorcycle.

public abstract class Vehicle {
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



Problem 02 - Animals
Создайте абстрактный класс Animal с наследниками Cat, Bear, Fox, Wolf

abstract class Animal {
	public Guid Id { get; set; }
	public string Name { get; set; }
	public double Weight { get; set; }


	public Animal() {
		Id = Guid.NewGuid();
	}
	
	public override string ToString() {
		return $"Type: {this.GetType().Name}, Name: {Name}, Weight: {Weight}";
	}

	public abstract void SayHello();
	public abstract double DistancePerDay();
	. . . 
}

Реализуйте виртуальный методы:
public override void SayHello(),

public override double DistancePerDay(),
возвращающий средний путь, проходимый в сутки зверем, сообразно его типу и весу (придумайте несложные математические выражения).



Напишите методы класса Animal:
public static void SortAnimals(List<Animal> animals),
сортирующий массив по типу зверей (в алфавитном порядке) и внутри каждого типа - по весу.
подсказка:
public static int CompareByTypeAndWegtht(Animal a, Animal b) {
	int result = a.GetType().Name.CompareTo(b.GetType().Name);
. . .	

public static (int bears, int cats, int wolfs, int foxes) GetAnimalTypes(List<Animal> animals)  
возвращающий количества зверей каждого типа.

public static double GetAverageDistance(List<Animal> animals, Type type = null),
возвращающий средний путь, проходимый зверями данного типа (или всеми, если type = null).


Продемонстрируйте работу всех методов:
  //int size = 1_000_000;
  int size = 100;
  var animals = new List<Animal>();
	
	//Заполните List animals случайным образом зверьми различных типов (class) (Cat, Bear, Fox, Wolf) с пустыми именами и случайными весами, характерными для данных типов зверей.
			
	Animal.SortAnimals(animals);
	Utils.PrintArrayByLines(animals, printAll: false);
	(int bears, int cats, int wolfs, int foxes) = Animal.GetAnimalTypes(animals);
	WriteLine($"{bears} {cats} {wolfs} {foxes}");
	WriteLine();


	var dist = Animal.GetAverageDistance(animals, (new Bear()).GetType());
	WriteLine($"average distance by bear: {dist:N2}");

	dist = Animal.GetAverageDistance(animals);
	WriteLine($"average distance by all animals: {dist:N2}");

	foreach (var item in animals) {
		item.SayHello();
	}



Problem 03 - Figures
Создайте абстрактный базовый класс Figure с абстрактными методами вычисления площади и периметра. Создайте производные классы: Rectangle (прямоугольник), Circle (круг), Trapezium (трапеция) со своими функциями площади и периметра. 
В конструкторе трапеции задавайте длины 4-н сторон, для определения площади найдите в справочниках довольно длинную формулу!  

В static class FigureDemo напишите методы:
public static double GetArea(List<Figure> figures) - общая площадь
public static double GetPerimeter(List<Figure> figures) - общий периметр
public static (double min, double max, double avr) GetAreaStats(List<Figure> figures) - макcимальное, минимальное и среднее значения площади
public static (double min, double max, double avr) GetPerimeterStats(List<Figure> figures) - то же с периметром
public static Figure FindFigureWithMaxArea(List<Figure> figures) - фигура с наибольшей площадью 
public static Figure FindFigureWithMaxPerimeter(List<Figure> figures) - фигура с наибольшим периметром 

public static SortByArea (List<Figure> figures)
public static SortByPerimeter (List<Figure> figures)

Создайте List<Figure> figures, содержащий фигуры разных типов.
Продемонстрируйте работу всех методов.
*/

namespace _0426 {
	class Program {
		public static void Demo1() {
			var autos = new List<Vehicle>() { new Car(), new Car(), new Truck(), new Bus(), new Motorcycle(), };

			VehicleDemo.Run(autos, 2000);
			Console.WriteLine($"\nСредняя скорость = {VehicleDemo.GetAverageSpeed(autos)}\n");

			VehicleDemo.Run(autos, 70);
			Console.WriteLine($"\nСредняя скорость = {VehicleDemo.GetAverageSpeed(autos)}\n");
		}
		public static void Demo2() {
			//int size = 1_000_000;
			int size = 100;
			var animals = Animal.GenerateAnimalList(size);

			//Заполните List animals случайным образом зверьми различных типов (class) (Cat, Bear, Fox, Wolf) с пустыми именами и случайными весами, характерными для данных типов зверей.
		
			Animal.SortAnimals(animals);
			Utils.PrintListByLines(animals, printAll: false);
			(int bears, int cats, int wolfs, int foxes) = Animal.GetAnimalTypes(animals);
			Console.WriteLine($"{bears} {cats} {wolfs} {foxes}");
			Console.WriteLine();


			Animal.GetAverageDistance(animals, (new Bear()).GetType());
			//Console.WriteLine($"average distance by bear: {dist:N2}");

			Animal.GetAverageDistance(animals);
			//Console.WriteLine($"average distance by all animals: {dist:N2}");

			foreach (var item in animals) {
				item.SayHello();
			}
		}
		public static void Main(string[] args) {
			//Demo1();
		  Demo2();
		}

  }
}