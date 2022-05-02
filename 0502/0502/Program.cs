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

global using System;

namespace _0502;
class Program {

	public static void Main(string[] args) {
		Problem2.Demo();
  }
}