using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 03
Используя файл students_10_000_000.txt, выведите список GroupID и число студентов в группе (по возрастанию числа студентов) в файл results.txt.*/
namespace Exam {
  class Student {
    public long StudentId { get; set; }
    public string IIN { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public DateTime Birthday { get; set; }
    public long GroupId { get; set; }



    public override string ToString() {
      return $"{StudentId} \t{IIN}\t{LastName} {FirstName}\t{Birthday:d}\t{GroupId}";
    }

    public static int CompareByIIN(Student a, Student b) {
      return a.IIN.CompareTo(b.IIN);
    }


    public static int CompareByGroupId(Student a, Student b) {
      return a.GroupId.CompareTo(b.GroupId);
    }


    public static int CompareByLastFirstName(Student a, Student b) {
      int result = a.LastName.CompareTo(b.LastName);
      if (result != 0) {
        return result;
      } else {
        return a.FirstName.CompareTo(b.FirstName);
      }
    }


    public static int CompareByLastFirstNameBirthday(Student a, Student b) {
      int result;
      result = a.LastName.CompareTo(b.LastName);
      if (result != 0) {
        return result;
      } else {
        result = a.FirstName.CompareTo(b.FirstName);
        if (result != 0) {
          return result;
        } else {
          return a.Birthday.CompareTo(b.Birthday);
        }
      }
    }
    private static Student GetStudentFromLine(string line) {
      long studentId, groupId;
      string[] words = line.Split('\t');
      Int64.TryParse(words[0], out studentId);
      DateTime birthday = DateTime.ParseExact(words[4], "MM/dd/yyyy", null);
      Int64.TryParse(words[5], out groupId);
      return new Student { StudentId = studentId, IIN = words[1], LastName = words[2], FirstName = words[3], Birthday = birthday, GroupId = groupId };
    }



    public static Student[] GetStudentArr(string fileName, int size = 10_000_000) {
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



    public static List<Student> GetStudentList(string fileName, int size = 10_000_000) {
      List<Student> students = new List<Student>();
      using (var file = new StreamReader(fileName)) {
        string line;
        int count = 0;
        while ((line = file.ReadLine()) != null) {
          students.Add(GetStudentFromLine(line));
          count++;
          if (count == size)
            break;
        }
      }
      return students;
    }
  }
  internal class GroupStudentCountDemo {
    static void GroupStudentCount(string writeFile, int size) {
      string studentsAll = @"C:\_0\students_10_000_000.txt";
      string studentsSample = @"C:\_0\students_1_000_sample.txt";

      Console.WriteLine("getting students...");
      var students = Student.GetStudentList(studentsAll,size);
      var studentsInGroup = new Dictionary<long, List<Student>>();
      
      foreach(Student student in students) {
        if (!studentsInGroup.ContainsKey(student.GroupId)) {
          var newStudentList = new List<Student>{student};
          studentsInGroup.Add(student.GroupId, newStudentList);
        } else {
          studentsInGroup[student.GroupId].Add(student);
        }
      }
      var studentsInGroupList = studentsInGroup.ToList();
      studentsInGroupList.Sort((a, b) => {
        return (a.Value.Count().CompareTo(b.Value.Count()));
      });
      Console.WriteLine("writing to file...");
      using(var file = new StreamWriter(writeFile)) {
        foreach(KeyValuePair<long,List<Student>> pair in studentsInGroupList) {
          Console.WriteLine($"{pair.Key}\t{pair.Value.Count()}");
          file.WriteLine($"{pair.Key}\t{pair.Value.Count()}");
        }
      }
    }

    public static void Demo() {
      int size = 1_000_000;
      string file = "results.txt";
      GroupStudentCount(file,size);
    }
  }
}
