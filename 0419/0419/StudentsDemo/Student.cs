using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
namespace StudentsNS {
	public class Student {
		public long StudentId { get; set; }
		public string IIN { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime Birthday { get; set; }
		public long GroupId { get; set; }
		public override string ToString() {
			return $"{StudentId} {IIN} {FirstName} {LastName} {Birthday} {GroupId}";
		}

		private static Student GetStudentFromLine(string line, bool checkWords=false) {
			string[] words = line.Split('\t');
			long studentId = Int64.Parse(words[0]);
      if (checkWords) {
				for(int i =0; i< words.Length; i++) {
					Write($"{words[i]}\t");
        }
				WriteLine();
      }
			string iin = words[1];
			string fName = words[2];
			string lName = words[3];
			DateTime birthday = DateTime.ParseExact(words[4], "MM/dd/yyyy", null);
			long groupId = Int64.Parse(words[5]);
			return new Student() { StudentId = studentId, IIN = iin, FirstName = fName, LastName = lName, Birthday = birthday, GroupId = groupId};
		}

		public static Student[] GetStudentsArr(string fileName, int size = 10_000_000) {
			Student[] students = new Student[size];
			using (var file = new StreamReader(fileName)) {
				string line;
				int count = 0;
				while ((line = file.ReadLine()) != null) {
					students[count++] = GetStudentFromLine(line);
					if (count == size)
						break;
				}
			}
			return students;
		}

		public static void PrintArray(Student[] arr) {
      // если больше 8 - то первые 4 построчно, строка многоточий, последние 4 построчно
      if (arr.Length <= 8) {
				for(int i=0; i< arr.Length; i++) {
					WriteLine(arr[i]);
        }
      } else {
				for(int i=0; i < 4; i++) {
					WriteLine(arr[i]);
        }
				WriteLine(". . .");
				for(int i = arr.Length - 4; i < arr.Length; i++) {
					WriteLine(arr[i]);
        }
      }
		}

	}

}
