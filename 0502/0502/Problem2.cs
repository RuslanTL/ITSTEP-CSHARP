using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 02 (StringListDelegates)
Напишите метод
public static List<string> GetAllWords(string fileName),
возвращающий все слова из текстового файла, используя следующие разделители:
char[] delims = {' ', '.', '!', '?', ',', '(', ')', '\t', '\n', '\r', '-', ';', ':' };
var arr = line.Split(delims, StringSplitOptions.RemoveEmptyEntries); //для удаления пустых строк


Напишите методы:
public static bool CheckIfAll(List<string> list, Func<string, bool> func)
public static bool CheckIfAny(List<string> list, Func<string, bool> func)
public static string FirstOrDefault(List<string> list, Func<string, bool> func)
public static int FindFirstIndex(List<string> list, Func<string, bool> func) 
public static int Count(List<string> list, Func<string, bool> func) 

CheckIfAll - проверяет, удовлетворяют ли все слова в list условию func.
CheckIfAny - проверяет, удовлетворяет ли хоть одно слово в list условию func.
FirstOrDefault - возвращает первое слово, удовлетрворяющее условию func или string.Empty, если не находит.
FindFirstIndex - возвращает индекс первого вхождения или -1, если не находит.
Count - возвращает количество слов, удовлетворяющих условию func.

В духе приведенного образца, напишите свою демонстрацию, использую БОЛЕЕ СЛОЖНЫЕ лямбда-выражения:
public static void Demo () {
	string fileName = @"C:\_0\Война и мир - UTF-8.txt";
	var list = UtilsNS.Strings.GetAllWords(fileName);
	bool result; int index, count;
	result = CheckIfAll(list, (s) => s.Length > 0);
	WriteLine(result);
	result = CheckIfAll(list, (s) => s.Length > 1);
	WriteLine(result);
	result = CheckIfAll(list, (s) => s.Contains("a"));
	WriteLine(result);
	
	result = CheckIfAny(list, (s) => s.Length == 16);
	WriteLine(result);
	WriteLine();

	result = CheckIfAny(list, (s) => s == "медведь");
	WriteLine(result);
	count = Count(list, (s) => s == "медведь");
	WriteLine(count);
	index = FindFirstIndex(list, (s) => s == "медведь");
	WriteLine(index);

	count = Count(list, (s) => s.Contains("медвед"));
	WriteLine(count);
  count = Count(list, (s) => s.StartsWith("мед"));
	WriteLine(count);

  var word = FirstOrDefault(list, (s) => s.StartsWith("мед"));
  WriteLine(word);
	WriteLine();

	count = Count(list, (s) => s == "Андрей" || s == "Пьер" || s == "Наташа" );
	WriteLine(count);
}
*/

namespace _0502 {



	public class Problem2 {
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
			foreach(string item in list) {
				string check = item.ToUpper();
				if (!func(check)) { return false; }
      }
			return true;

    }
		public static bool CheckIfAny(List<string> list, Func<string, bool> func) {
			foreach(string item in list) {
				string check = item.ToUpper();
				if (func(check)) { return true; }
      }
			return false;
    }
		public static string FirstOrDefault(List<string> list, Func<string, bool> func) {

			foreach(string item in list) {
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

		public static void Demo() {
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
			index = FindFirstIndex(list, (s) => s.Length>queryInt);
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

			var speechParts = new List<string> { "в", "и","или","но","при","через","хотя","если","на","а","не"};
			for (int i = 0; i < speechParts.Count; i++) {
				speechParts[i] = speechParts[i].ToUpper();
			}
			count = Count(list, (s) => speechParts.Contains(s));
			Console.WriteLine($"amount of speech parts in Book: {count}");
		}
	}
}
