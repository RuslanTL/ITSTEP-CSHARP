using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 02 (StringListDelegates)
Напишите обобщенные методы методы (опираясь на предыдущую задачу StringListDelegates):
public static bool CheckIfAll<T>(List<T> list, Func<T, bool> func)
public static bool CheckIfAny<T>(List<T> list, Func<T, bool> func)
public static T FirstOrDefault<T>(List<T> list, Func<T, bool> func)
public static int FindFirstIndex<T>(List<T> list, Func<T, bool> func) 
public static int Count<T>(List<T> list, Func<T, bool> func) 

public static T Min<T>(List<T> list) where T : IComparable<T>  
public static T Min<T>(List<T> list, Func<T, bool> func) where T : IComparable<T>  
public static T Max<T>(List<T> list) where T : IComparable<T>
public static T Max<T>(List<T> list, Func<T, bool> func) where T : IComparable<T>

public static List<T> Where<T> (List<T> list, Func<T, bool> func)

public static List<T> GetSorted<T> (List<T> list) where T : IComparable<T>
public static List<T> GetSorted<T>(List<T> list, Comparison<T> comparison)

public static bool IsSorted<T> (List<T> list) where T : IComparable<T>
public static bool IsSorted<T>(List<T> list, Comparison<T> comparison)



CheckIfAll - проверяет, удовлетворяют ли все элементы в list условию func.
CheckIfAny - проверяет, удовлетворяет ли хоть один элемент в list условию func.
FirstOrDefault - возвращает первый элемент, удовлетворяющий условию func или default(T), если не находит.
FindFirstIndex - возвращает индекс первого вхождения элемента или -1, если не находит.
Count - возвращает количество элементов, удовлетворяющих условию func.
Min - если минимальный элемент не может быть найден, выбрасывайте исключение (уточните у преподавателя).
Max - если максимальный элемент не может быть найден, выбрасывайте исключение (уточните у преподавателя). 
Where - возвращает подмножество list, удовлетворяющее условию func.
GetSorted - возврашает новый отсортированный List<T> (исходный не меняется! Используйте для создания копии метод list.ToList();).
IsSorted - проверяет List на упорядоченность.

Продемонстрируйте их работу на List<int> (большой, рандомный!) и на List<int> из текста "Война и мир" (аналогично демонстрации задачи StringListDelegates, но с добавленными выше методами). 


*/

namespace _0503 {



	public class GenericListDemo {
		public static List<string> GetAllWords(string fileName) {
			var wordList = new List<string>();
			char[] delims = { ' ', '.', '!', '?', ',', '(', ')', '\t', '\n', '\r', '-', ';', ':' };
			using (var file = new StreamReader(fileName)) {
				Console.WriteLine("file read begin");
				string line;
				while ((line = file.ReadLine()) != null) {
					var lineList = Enumerable.ToList(line.Split(delims, StringSplitOptions.RemoveEmptyEntries));
					wordList.AddRange(lineList);
				}
			}
			return wordList;
		}
		public static bool CheckIfAll(List<string> list, Func<string, bool> func) {
			foreach (string item in list) {
				string check = item.ToUpper();
				if (!func(check)) { return false; }
			}
			return true;

		}
		public static bool CheckIfAny(List<string> list, Func<string, bool> func) {
			foreach (string item in list) {
				string check = item.ToUpper();
				if (func(check)) { return true; }
			}
			return false;
		}
		public static string FirstOrDefault(List<string> list, Func<string, bool> func) {

			foreach (string item in list) {
				string check = item.ToUpper();
				if (func(check)) { return item; }
			}
			return string.Empty;
		}
		public static int FindFirstIndex(List<string> list, Func<string, bool> func) {
			return list.IndexOf(FirstOrDefault(list, func));
		}
		public static int Count(List<string> list, Func<string, bool> func) {
			int cnt = 0;

			foreach (string item in list) {
				string check = item.ToUpper();
				if (func(check)) {
					cnt++;
				}
			}
			return cnt;
		}

		public static T Min<T>(List<T> list) where T : IComparable<T> {
			T min = list[0];
			foreach(T item in list) {
        if (min.CompareTo(item) > 0) {
					min = item;
        }
      }
			return min;
    }
		public static T Min<T>(List<T> list, Func<T, bool> func) where T : IComparable<T> {

			bool isChecked = false;
			T min = list[0];
			foreach (T item in list) {
				if (func(item)) {
					isChecked = true;
					if (min.CompareTo(item) > 0) {
						min = item;
					}
				}
			}
      if (!isChecked) {
				throw new Exception("No items met conditions!");
      }
			return min;
		}


		public static T Max<T>(List<T> list) where T : IComparable<T> {
			T max = list[0];
			foreach (T item in list) {
				if (max.CompareTo(item) < 0) {
					max = item;
				}
			}
			return max;
		}
		public static T Max<T>(List<T> list, Func<T, bool> func) where T : IComparable<T> {
			bool isChecked = false;
			T max = list[0];
			foreach (T item in list) {
				if (func(item)) {
					isChecked = true;
					if (max.CompareTo(item) < 0) {
						max = item;
					}
				}
			}
			if (!isChecked) {
				throw new Exception("No items met conditions!");
			}
			return max;

		}

		public static List<T> Where<T>(List<T> list, Func<T, bool> func) {
			var checkedList = new List<T>();

			foreach (T item in list) {
				if (func(item)) {
					checkedList.Add(item);
				}
			}

			return checkedList;
		}

		public static List<T> GetSorted<T>(List<T> list) where T : IComparable<T> {
			var newList = list.ToList();
			newList.Sort();
			return newList;
    }
		public static List<T> GetSorted<T>(List<T> list, Comparison<T> comparison) {
			var newList = list.ToList();
			newList.Sort(comparison);
			return newList;
		}

		public static bool IsSorted<T>(List<T> list) where T : IComparable<T> {
			var copy = list.ToList();
			copy.Sort();
			if (copy == list) {
				return true;
			} else return false;
			
    }
		public static bool IsSorted<T>(List<T> list, Comparison<T> comparison) {
			var copy = list.ToList();
			copy.Sort(comparison);
			if (copy == list) {
				return true;
			} else return false;
		}


		static void BookDemo() {
			string fileName = @"C:\_0\Война и мир - UTF-8.txt";
			var list = GetAllWords(fileName);
			bool result; int index, count;
			string query = "Почему";
			result = CheckIfAny(list, (s) => s == query.ToUpper());
			Console.WriteLine($"Book has word {query}:{result}");

			query = "Интернет";
			result = CheckIfAny(list, (s) => s == query.ToUpper());
			Console.WriteLine($"Book has word {query}:{result}");

			int queryInt = 14;
			index = FindFirstIndex(list, (s) => s.Length > queryInt);
			Console.WriteLine($"first word with length above {queryInt}: {index}  {list[index]}");

			query = "Война";
			count = Count(list, (s) => s == query.ToUpper());
			Console.WriteLine($"amount of times {query} found in book: {count}");

			query = "Мир";
			count = Count(list, (s) => s == query.ToUpper());
			Console.WriteLine($"amount of times {query} found in book: {count}");

			query = "При";
			var word = FirstOrDefault(list, (s) => s.StartsWith(query.ToUpper()));
			Console.WriteLine($"First word that starts wth {query}: {word}");

			query = "Пере";
			word = FirstOrDefault(list, (s) => s.StartsWith(query.ToUpper()));
			Console.WriteLine($"First word that starts wth {query}: {word}");

			var speechParts = new List<string> { "в", "и", "или", "но", "при", "через", "хотя", "если", "на", "а", "не" };
			for (int i = 0; i < speechParts.Count; i++) {
				speechParts[i] = speechParts[i].ToUpper();
			}
			count = Count(list, (s) => speechParts.Contains(s));
			Console.WriteLine($"amount of speech parts in Book: {count}");
		}
		static void RandomDemo() {
			
			var list1 = Enumerable.ToList(Utils.GetIntArray(100, 10,20));
			int result;
			var newList = new List<int>();
			Console.WriteLine("\nGenerated random int list");
			Console.WriteLine($"Min in list: {Min(list1)}");

			result = Min(list1, (n) => n % 2 != 0);
			Console.WriteLine($"Min odd number in list: {result}");

			newList = Where(list1, (n) => n > 10);
			Console.WriteLine("sublist with all elements > 10 ");
			Utils.PrintList(newList);
			var copyList = newList.ToList();
			newList = GetSorted(newList,(a,b)=>b.CompareTo(a));
			Console.WriteLine("sublist sorted desc:");
			Utils.PrintList(newList);
			Console.WriteLine($"sorted list same as original list?: {IsSorted(copyList, (a, b) => b.CompareTo(a))}");

    }

		public static void Demo() {
			//BookDemo();
			RandomDemo();
		}
	}
}
