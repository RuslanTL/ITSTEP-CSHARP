using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 01
Подсчитайте частоту вхождения всех слов в файле "Война и мир - UTF-8.txt".
Выведите первые и последние 20 слов, отсортированные по частоте вхождения (а внутри - по алфавиту). */
namespace _0505 {
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
		public static void Demo() {
			string fileName = @"C:\_0\Война и мир - UTF-8.txt";
			var wordList = GetAllWords(fileName);
			var wordDict = new Dictionary<string,int>();
			foreach(string item in wordList) {

				if(wordDict.ContainsKey(item)) {
					wordDict[item]++;
				} else {
					wordDict.TryAdd(item, 1);
        }
      }
			var wordList2 = wordDict.ToList();
			wordList2.Sort((a, b) => {
				int result = a.Value.CompareTo(b.Value);
				if (result != 0) { return result; } else {return a.Key.CompareTo(b.Key); }
			}
      );
			string[] symbols = { "*","[","]"};
      for (int i = 0; i < wordList2.Count; i++) {
        KeyValuePair<string, int> item = wordList2[i];
        if (symbols.Contains(item.Key)) {
					wordList2.RemoveAt(i);
        }
      }



      Utils.PrintListPairs(wordList2);
		}
	}
}
