using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _0505;
class Student {
  public long StudentId { get; set; }
  public string IIN { get; set; }
  public string LastName { get; set; }
  public string FirstName { get; set; }
  public DateTime Birthday { get; set; }
  public long GroupId { get; set; }

  public string GroupName { get; set; }

  public override string ToString() {
    return $"{StudentId} \t{IIN}\t{LastName} {FirstName}\t{Birthday:d}\t{GroupId}\t{GroupName}";
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
  private static Student GetStudentFromLine(string line, bool withName) {
    long studentId, groupId;
    string[] words = line.Split('\t');
    Int64.TryParse(words[0], out studentId);
    DateTime birthday = DateTime.ParseExact(words[4], "MM/dd/yyyy", null);
    Int64.TryParse(words[5], out groupId);
    if (withName) {
      return new Student { StudentId = studentId, IIN = words[1], LastName = words[2], FirstName = words[3], Birthday = birthday, GroupId = groupId, GroupName = words[6] };
    } else {
      return new Student { StudentId = studentId, IIN = words[1], LastName = words[2], FirstName = words[3], Birthday = birthday, GroupId = groupId};
    }
    
  }



  public static Student[] GetStudentArr(string fileName, int size = 10_000_000) {
    Student[] students = new Student[size];
    using (var file = new StreamReader(fileName)) {
      string line;
      int count = 0;
      while ((line = file.ReadLine()) != null) {
        students[count++] = GetStudentFromLine(line,false);
        if (count == size)
          break;
      }
    }
    return students;
  }



  public static List<Student> GetStudentWithGroupNameList(string studFileName, string groupFileName, int size = 10_000_000) {
    var groups = new Groups(groupFileName);

    var list = new List<Student>();
    using (var file = new StreamReader(studFileName)) {
      using (var file2 = new StreamReader(groupFileName)) {
        string line, line2;
        int count = 0;
        while ((line2 = file2.ReadLine()) != null && (line = file.ReadLine()) != null) {
          line += $"\t{groups.FindByID(Int64.TryParse(line.Split('\t')[5],out long n))}";

          list.Add(GetStudentFromLine(line, true));
          
        }
      }
      
    }
    return list;
  }
  public static List<Student> GetStudentList(string fileName, int size = 10_000_000) {
    List<Student> students = new List<Student>();
    using (var file = new StreamReader(fileName)) {
      string line;
      int count = 0;
      while ((line = file.ReadLine()) != null) {
        students.Add(GetStudentFromLine(line,false));
        count++;
        if (count == size)
          break;
      }
    }
    return students;
  }
}
class Students {
  Dictionary<long, Student> _dictByID = new Dictionary<long, Student>();
  Dictionary<string, Student> _dictByIIN = new Dictionary<string, Student>();

  public Students(string fileName, int size = 0) {
    var sArr = Student.GetStudentArr(fileName, size);
    foreach(Student item in sArr) {
      _dictByID.TryAdd(item.StudentId, item);
      _dictByIIN.TryAdd(item.IIN, item);
    }
  }



  public Student FindByID(long studentID) {
    try {
      _dictByID.TryGetValue(studentID, out Student result);
      return result;
    } catch (Exception ex) {
      Console.WriteLine(ex);
      return new Student();
    }
  }


  public Student FindByIIN(string iIN) {
    try {
      _dictByIIN.TryGetValue(iIN, out Student result);
      return result;
    } catch (Exception ex) {
      Console.WriteLine(ex);
      return new Student();
    }
  }
  
} 