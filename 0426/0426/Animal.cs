using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 02 - Animals
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
	}*/
namespace _0426 {
	public abstract class Animal {
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

		/*public static void SortAnimals(List<Animal> animals),
сортирующий массив по типу зверей (в алфавитном порядке) и внутри каждого типа - по весу.
подсказка:
public static int CompareByTypeAndWegtht(Animal a, Animal b) {
	int result = a.GetType().Name.CompareTo(b.GetType().Name);
. . .	

public static (int bears, int cats, int wolfs, int foxes) GetAnimalTypes(List<Animal> animals)  
возвращающий количества зверей каждого типа.

public static double GetAverageDistance(List<Animal> animals, Type type = null),
возвращающий средний путь, проходимый зверями данного типа (или всеми, если type = null).
*/

		public static void SortAnimals(List<Animal> animals) {
			animals.Sort(CompareByTypeAndWeight);
		}


		public static int CompareByTypeAndWeight(Animal a, Animal b) {
			int result = a.GetType().Name.CompareTo(b.GetType().Name);
			if (result != 0) {
				return result;
			} else {
				return a.Weight.CompareTo(b.Weight);
			}
		}


		public static (int bears, int cats, int wolfs, int dogs) GetAnimalTypes(List<Animal> animals) {
			int bears = 0;
			int cats = 0;
			int wolfs = 0;
			int dogs = 0;
			foreach (var animal in animals) {
				switch (animal.GetType().Name) {
					case "Bear": bears++; break;
					case "Cat": cats++; break;
					case "Wolf": wolfs++; break;
					case "Dog": dogs++; break;
					default: break;
				}
			}
			return (bears, cats, wolfs, dogs);
		}


		public static double GetAverageDistance(List<Animal> animals, Type type = null) {
			double distanceSum = 0;
			int typeSum = 0;
			if (type != null) {
				foreach (var animal in animals) {
					if (animal.GetType() == type) {
						typeSum++;
						distanceSum += animal.DistancePerDay();
					}
				}
				double avg = distanceSum / typeSum;
				Console.WriteLine($"average distance of {typeSum} {type.Name}s: {avg:N2}m");
				return avg;
			} else {
				foreach (var animal in animals) {
					typeSum++;
					distanceSum += animal.DistancePerDay();
				}
				double avg = distanceSum / typeSum;
				Console.WriteLine($"average distance of {typeSum} animals: {avg:N2}m");
				return avg;
			}

		}


		public static List<Animal> GenerateAnimalList(int size){

			var animals = new List<Animal>();
			var rnd = new Random();
			for(int i =0; i< size; i++) {
				double choice = rnd.NextDouble();
				if (choice < 0.25) {
					animals.Add(new Bear());
				} else if(choice < 0.5) {
					animals.Add(new Cat());
        } else if(choice < 0.75) {
					animals.Add(new Wolf());
        } else if(choice < 1) {
					animals.Add(new Dog());
        }

      }
			return animals;
		}

	}
	/*Реализуйте виртуальный методы:
public override void SayHello(),

public override double DistancePerDay(),
возвращающий средний путь, проходимый в сутки зверем, сообразно его типу и весу (придумайте несложные математические выражения).*/

	public class Cat : Animal {

		public Cat() {
			var rnd = new Random();
			Weight = rnd.Next(3, 8);
    }
		public override void SayHello() {
			Console.WriteLine($"I am {GetType()} {Name}. Meow");
    }
		public override double DistancePerDay() {
			double typeWeight = 0.85;
			double weightWeight = 1+((1 / Weight)/4);
			double distance = 1000 * typeWeight * weightWeight;
			return distance;
    }

	}
	public class Bear : Animal {
		public Bear() {
			var rnd = new Random();
			Weight = rnd.Next(100,200);
		}
		public override void SayHello() {
			Console.WriteLine($"I am {GetType()} {Name}. Roar");
		}
		public override double DistancePerDay() {
			double typeWeight = 0.35;
			double weightWeight = 1 + ((1 / Weight) / 4);
			double distance = 1000 * typeWeight * weightWeight;
			return distance;
		}

	}
	public class Wolf : Animal {
		public Wolf() {
			var rnd = new Random();
			Weight = rnd.Next(10,20);
		}
		public override void SayHello() {
			Console.WriteLine($"I am {GetType()} {Name}. Wooo");
		}
		public override double DistancePerDay() {
			double typeWeight = 0.7;
			double weightWeight = 1 + ((1 / Weight) / 4);
			double distance = 1000 * typeWeight * weightWeight;
			return distance;
		}

	}
	public class Dog : Animal {
		public Dog() {
			var rnd = new Random();
			Weight = rnd.Next(5,10);
		}
		public override void SayHello() {
			Console.WriteLine($"I am {GetType()} {Name}. Bark");
		}
		public override double DistancePerDay() {
			double typeWeight = 0.6;
			double weightWeight = 1 + ((1 / Weight) / 4);
			double distance = 1000 * typeWeight * weightWeight;
			return distance;
		}

	}
}
