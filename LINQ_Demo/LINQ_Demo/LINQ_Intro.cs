namespace LinqDemoNS;
class LINQ_Intro {
  static List<StudentsNS.Student> _students = StudentsNS.Student.GetStudentList(Globals.Students_10_000_000_fileName, 10_000).ToList();


  static void SyntaxDemo() {
    var filteredNames1 = from s in _students
                         where s.LastName.StartsWith("Bo")
                         orderby s.LastName
                         select s.LastName;
    foreach (var item in filteredNames1) { WriteLine(item); }
    WriteLine();
    //or:
    var filteredNames2 = _students.Where(s => s.LastName.StartsWith("Bo")).OrderBy(s => s.LastName).Select(s => s.LastName);
    foreach (var item in filteredNames2) { WriteLine(item); }



  }

  static void ChainingQueryOperators_Demo() {
    var query1 = _students.Where(s => s.LastName.Contains("ac")).OrderBy(s => s.LastName.Length).ThenBy(s => s.LastName).ThenBy(s => s.FirstName).Select(s => s.LastName.ToUpper()).Take(100);
    foreach (string name in query1) WriteLine(name);
    //or:
    var query2 = (from s in _students
                  where s.LastName.Contains("ac")
                  orderby s.LastName.Length, s.LastName, s.FirstName
                  select s.LastName.ToUpper()).Take(100);
    foreach (string name in query2) WriteLine(name);

    //or:
    var filtered = _students.Where(s => s.LastName.Contains("ac")).Take(100);
    var sorted = filtered.OrderBy(s => s.LastName.Length).ThenBy(s => s.LastName).ThenBy(s => s.FirstName);
    var finalQuery = sorted.Select(s => s.LastName.ToUpper());
    foreach (var item in filtered) { Write(item.LastName + "|"); }
    WriteLine();
    foreach (var item in sorted) { Write(item.LastName + "*"); }
    WriteLine();
    foreach (var item in finalQuery) { Write(item + "+"); }
  }


  static void NaturalOrdering_Demo() {
    var list10 = _students.Take(10).OrderBy(s => s.LastName);
    foreach (var item in list10) WriteLine(item.LastName);
    WriteLine();
    var list7 = list10.Skip(3);
    foreach (var item in list7) WriteLine(item.LastName);
    WriteLine();
    var listRev = list7.Reverse();
    foreach (var item in listRev) WriteLine(item.LastName);
  }



  static void ElementOperators_Demo() {
    int[] numbers = { 10, 9, 8, 7, 6 };
    int firstNumber = numbers.First();                           // 10
    int lastNumber = numbers.Last();                             // 6
    int secondNumber = numbers.ElementAt(1);                     // 9
    int secondLowest = numbers.OrderBy(n => n).Skip(1).First();  // 7

    //int fistNegative1 = numbers.First(p => p < 0);  //rantime exception!
    int fistNegative2 = numbers.FirstOrDefault(p => p < 0);
    WriteLine($"fistNegative2 = {fistNegative2}");
  }



  static void AggregationsMehods_Demo() {
    long cnt = _students.Count(s => s.Birthday.Year > 2000);
    DateTime minDate = _students.Min(s => s.Birthday);
    DateTime maxDate = _students.Max(s => s.Birthday);

    int[] numbers = { -2, 1, 2, 3, -10, 0, 0 };
    var sum = numbers.Where(p => p > 0).Sum();
    var avg = numbers.Where(p => p <= 0).Average(p => p * p);

  }



  static void Quantifiers_Demo() {
    bool hasIIN = _students.Select(s => s.IIN).Contains("999999999894");
    bool hasMoreThanZeroElements = _students.Any();
    bool hasAnLastName = _students.Any(s => s.LastName == "Shields");

    var bool1 = new int[] { 2, 3, 4 }.Contains(3);
    var bool2 = new int[] { 2, 3, 4 }.Any(n => n == 3);
    var bool3 = new int[] { 2, 3, 4 }.Any(n => n > 10);
    var bool4 = new int[] { 2, 3, 4 }.Where(n => n > 10).Any();


    var query = "Hello".Distinct();
    bool isEqual = query.SequenceEqual("Helo");
  }



  static void SetOperations_Demo() {
    int[] seq1 = { 1, 2, 3 };
    int[] seq2 = { 3, 4, 5 };
    var concat = seq1.Concat(seq2);         // { 1, 2, 3, 3, 4, 5 }
    var union = seq1.Union(seq2);           // { 1, 2, 3, 4, 5 }
    var intersect = seq1.Intersect(seq2);   // { 3 }
    var except1 = seq1.Except(seq2);        // { 1, 2 } 
    var except2 = seq2.Except(seq1);        // { 4, 5 }
  }


  static void MixedSyntax_Demo() {
    int matches = (from s in _students where s.LastName.Contains("ab") select s).Count();
    var first = (from s in _students orderby s.LastName descending select s).First();
  }



  static void DeferredExecution_Demo() {
    var numbers = new List<int> { 1 };
    var query1 = numbers.Select(n => n * 10);
    numbers.Add(2);
    foreach (int n in query1) WriteLine(n);
    WriteLine();

    //compare with:
    numbers = new List<int> { 1 };
    var query2 = numbers.Select(n => n * 10).ToList();
    numbers.Add(2);
    foreach (int n in query2) WriteLine(n);
  }



  static void Reevaluation_Demo() {
    var numbers = new List<int>() { 1, 2 };
    var query = numbers.Select(n => n * 10);
    foreach (int n in query) WriteLine(n);
    WriteLine("--------------------\n");

    numbers.Clear();
    foreach (int n in query) WriteLine(n);
    WriteLine("--------------------\n");
  }



  public static void Demo() {
    SyntaxDemo();
    ChainingQueryOperators_Demo();
    NaturalOrdering_Demo();
    ElementOperators_Demo();
    AggregationsMehods_Demo();
    Quantifiers_Demo();
    SetOperations_Demo();
    MixedSyntax_Demo();
    DeferredExecution_Demo();
    Reevaluation_Demo();
  }
}

