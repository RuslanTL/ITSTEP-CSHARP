using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0504 {
  public class Problem1 {
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
		/*Problem 01 
Подсчитайте количество различных слов в тексте "Война и мир" (файл "Война и мир - UTF-8.txt") с помощью HashSet. Выведите, также, и общее количество слов.
*/
		public static void Demo() {
			string fileName = @"C:\_0\Война и мир - UTF-8.txt";
			var list = GetAllWords(fileName);
			var map = new HashSet<string>();
			foreach(string item in list) {
				map.Add(item);
      }
			Console.WriteLine($"Unique words in book: {map.Count}");
			Console.WriteLine($"Total words in book: {list.Count}");
		}

  }
}
