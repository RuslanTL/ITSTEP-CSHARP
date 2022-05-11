namespace StudentsNS;
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
        students[count] = GetStudentFromLine(line);
        count++;
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

