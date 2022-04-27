using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 02 - IValuableWithPtoperty 
Аналогично Problem 01, но для интерфейса со свойством Value(вместо метода GetValue).
interface IValuable {
  double Value {get; set};
}
*/

namespace _0427_2;

class Program {
	public static void Demo2() {
		var list = new List<IValuable> { new Book(100), new Rarity(10), new Statue(80), new Picture(50) };
		foreach (var item in list) {
			Console.WriteLine($"value of {item.GetType().Name}: {item._value}");
		}
		Console.WriteLine();

		ValuableDemo.SortByValue(list);
		foreach (var item in list) {
			Console.WriteLine($"value of {item.GetType().Name}: {item._value}");
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
