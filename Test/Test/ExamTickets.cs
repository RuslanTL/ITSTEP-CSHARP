using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 01
Назовите файл списка студентов Вашей группы in.txt.
Прочитав файл, назначьте каждому студенту номер билета из интервала 1 - (к-во студентов) случайным образом.
Номера билетов не должны повторяться!

Выведите результаты, упорядочив по ФАМИЛИИ, в файл out1.txt построчно в формате:
[Порядковый №] [фамилия] [имя] [номер билета].
Например:
1  Валиханов Чокан   8
2  Кунанбаев Абай   12  
3  Пушкин Александр 10
. . .
14 Шопен Фредерик    4

Выведите результаты, упорядочив по НОМЕРУ БИЛЕТА, в файл out2.txt построчно в формате:
[номер билета] [фамилия] [имя].
Например:
1 . . .
2 . . .
. . .
8  Валиханов Чокан
12 Кунанбаев Абай   
10 Пушкин Александр 
14 Шопен Фредерик

Перед формированием файлов должен вызываться метод проверки уникальности номеров
static bool IsUnique(List<int> ticketList).

При каждом запуске должна генерироваться новая случайная последовательность билетов!
*/
namespace Test {

  class Student {

    public string LastName { get; set; }
    public string FirstName { get; set; }
    public long _ticket { get; set; }

    public override string ToString() {
      return $"{LastName} {FirstName}\t{_ticket}";
    }

    public static int CompareByLastFirstName(Student a, Student b) {
      int result = a.LastName.CompareTo(b.LastName);
      if (result != 0) {
        return result;
      } else {
        return a.FirstName.CompareTo(b.FirstName);
      }
    }

    public static int CompareByTicket(Student a, Student b) {
      return a._ticket.CompareTo(b._ticket);
    }
    public static Student GetStudentFromLine(string line) {
      
      string[] words = line.Split('\t');
      return new Student {LastName=words[0],FirstName=words[1],_ticket=0};

    }
  }

  internal class ExamTickets {
    static bool IsUnique(List<int> ticketList) {
      return ticketList.Distinct().Count() == ticketList.Count();
    }
    static void readList(string fileName) {
      using (var file = new StreamReader(fileName)) {
        string line;
        int n = 1;
        var tickets = new List<int>();
        var students = new List<Student>();
        while ((line = file.ReadLine()) != null) {

          students.Add(Student.GetStudentFromLine(line));
          tickets.Add(n);
          n++;
        }
        Console.WriteLine($"tickets are unique: {IsUnique(tickets)}");
        students.Sort(Student.CompareByLastFirstName);
        using(var output = new StreamWriter("out.txt")) {
          Console.WriteLine("out.txt created");
          var rnd = new Random();

          for(int i =0; i < students.Count(); i++) {
            var ticket = tickets[rnd.Next(tickets.Count())];
            tickets.Remove(ticket);
            students[i]._ticket = ticket;
            output.WriteLine($"{i+1} {students[i]}");
          }
        }
        students.Sort(Student.CompareByTicket);
        using (var output = new StreamWriter("out2.txt")) {
          Console.WriteLine("out2.txt created");
          for (int i = 0; i < students.Count(); i++) {

            output.WriteLine($"{students[i]._ticket} {students[i]}");
          }
        }
      }

    }

    public static void Demo() {
      readList("in.txt");
    }
  }
}
