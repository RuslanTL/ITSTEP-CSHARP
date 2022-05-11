namespace LinqDemoNS;
class StudGroup {
  public string StudentName { get; set; }
  public string GroupName { get; set; }
}


class LINQ_Advanced {
  static void Joining_Demo() {
    var students = StudentsNS.Student.GetStudentList(Globals.Students_10_000_000_fileName, 1_000_000);
    var groups = StudentsNS.Group.GetGroupsList(Globals.Groups_1_000_000_fileName);

    var query1 = from s in students
                 join g in groups on s.GroupId equals g.GroupId
                 where g.GroupName.StartsWith("AAA")
                 orderby g.GroupName, s.LastName, s.FirstName
                 select new StudGroup { StudentName = $"{s.LastName} {s.FirstName}", GroupName = g.GroupName };

    foreach (var item in query1) { WriteLine($"{item.GroupName}; {item.StudentName}"); }
    WriteLine();
    WriteLine($"query1.Count() = {query1.Count()}\n");

    // fluent syntax:
    var query2 = students.Join(groups.Where(g => g.GroupName.StartsWith("AAA")), s => s.GroupId, g => g.GroupId, (s, g) => new StudGroup { StudentName = $"{s.LastName} {s.FirstName}", GroupName = g.GroupName });
    WriteLine($"query2.Count() = {query2.Count()}\n");

    // fluent syntax with OrderBy:
    var query3 = students.Join(groups.Where(g => g.GroupName.StartsWith("AAA")), s => s.GroupId, g => g.GroupId, (s, g) => new StudGroup { StudentName = $"{s.LastName} {s.FirstName}", GroupName = g.GroupName })
      .OrderBy(p => p.GroupName).ThenBy(p => p.StudentName);
    WriteLine($"query3.Count() = {query3.Count()}\n");

  }



  public static void Demo() {
    Joining_Demo();
  }
}
