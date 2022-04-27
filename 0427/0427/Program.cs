// See https://aka.ms/new-console-template for more information
global using System;

namespace _0427;
/*Problem 01 - IValuable
Реализуйте интерфейс IValuable
interface IValuable {
  double GetValue();
}
для классов Book, Picture, Statue, Rarity (разместите их в файле ValuableClasses.cs).
Стоимость объектов данных классов задается в их конструкторах.
Например:
class Picture : IValuable {
	double _value;

	public Picture(double value) {
		_value = value;
	}

	public double GetValue() => _value * 1.1;
}

В классе static class ValuableDemo:

Напишите метод
static List<IValuable> GeRandomValuableList(int size),
возвращающий List, заполненный случайным образом объектами, реализующими  интерфейс IValuable.

Напишите метод
static double GetWorth(IValuable v),
возвращающий стоимость любого из переданного ей объекта.

Напишите метод
static double GetWorth(List<IValuable> list),
возвращающий суммарную стоимость объектов в массиве.

Напишите метод
static void BubleSort(List<IValuable> list),
сортирующий по возрастанию методом пузырька любой List, элементы которого реализуют интерфейс IValuable.

Напишите метод
static void SortByValue(List<IValuable> list) {
	list.Sort(CompareByValue);
}
сортирующий с помощью библиотечного метода Sort по УБЫВАНИЮ любой List, элементы которого реализуют интерфейс IValuable с помощью вспомогательного метода
static int CompareByValue(IValuable a, IValuable b)


Продемонстрируйте работу, В ЧАСТНОСТИ ВЫПОЛНИВ:
public static void Demo() {
	var list = new List<IValuable> { new Book(100), new Rarity(10), new Statue(80), new Picture(50) };
	BubleSort(list);
	foreach (var item in list) {
		WriteLine(item.GetValue());
	}
	WriteLine();

	SortByValue(list);
	foreach (var item in list) {
		WriteLine(item.GetValue());
	}
  WriteLine();
	WriteLine($"Общая стоимость: {GetWorth(arr)}");
	//. . . 
}

*/
class Program {


	public static void Demo1() {
		var objects = new List<IRunnable>() { new Car(), new Car(), new Truck(), new Man(), new Bear(), };

		IRunnableDemo.Run(objects, 2000);
		Console.WriteLine($"\nСредняя скорость = {IRunnableDemo.GetAverageSpeed(objects)}\n");

		IRunnableDemo.Run(objects, 70);
		Console.WriteLine($"\nСредняя скорость = {IRunnableDemo.GetAverageSpeed(objects)}\n");
	}
	public static void Demo2() {
		var list = new List<IValuable> { new Book(100), new Rarity(10), new Statue(80), new Picture(50) };
		foreach (var item in list) {
			Console.WriteLine($"value of {item.GetType().Name}: {item.GetValue()}");
		}
		Console.WriteLine();

		ValuableDemo.SortByValue(list);
		foreach (var item in list) {
			Console.WriteLine($"value of {item.GetType().Name}: {item.GetValue()}");
		}
		Console.WriteLine();
		Console.WriteLine($"Общая стоимость: {ValuableDemo.GetWorth(list)}");
		//. . . 
	}
	static void Main(string[] args) {
		//Demo1();
		Demo2();
  }
}