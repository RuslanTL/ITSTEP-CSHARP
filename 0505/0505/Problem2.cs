using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

/*Problem 02
Реализуйте класс Students с методами быстрого поиска по StudentID и IIN:
class Students {
	Dictionary<long, Student> _dictByID = new Dictionary<long, Student>();
	Dictionary<string, Student> _dictByIIN = new Dictionary<string, Student>();

	public Students(string fileName, int size = 0) {	. . .

  public Student FindByID(long studentID) { . . .
	
	public Student FindByIIN(string iIN) { . . .
}	

Реализуйте класс Groups с методом быстрого поиска по GroupID:
  public Group FindByID(long groupID) { . . .

Добавьте в класс Student свойство
public string GroupName { get; set; }

public override string ToString() {
	return $"{StudentId} \t{IIN}\t{LastName} {FirstName}\t{Birthday:d}\t{GroupId}\t{GroupName}";
}

Напишите
public static List<Student> GetStudentWithGroupNameList(string studFileName, string groupFileName, int size = 10_000_000) { . . .
возвращающий список студентов с заполненным полем GroupName.


Сформируйте файл studentsAndGroups_10_000_000.txt c полями, аналогичными полям в файле students_10_000_000.txt и с добавленным последним полем GroupName.
Будьте готовы к быстрому формированию этого файла на экзамене!


Измерьте времена работы поиска FindByID и FindByIIN по всем 10_000_000 студентам, для всех StudentID и IIN из students_1_000_sample.txt. Сравните с аналогичными временами поиска с помощью List.Find, который делает поиск первого вхождения методом полного перебора элементов списка.
Измерения проводите в режиме Release, x64.
 */
namespace _0505;
public class Problem2{

	public static void Demo() {
		int size = 1000;
		string stufFileName = @"C:\_0\students_10_000_000.txt";
		string groupFileName = @"C:\_0\groups_1_000_000.txt";
		var students = new Students(stufFileName, size);
		var groups = new Groups(groupFileName,size);
		
	


		var sw = new Stopwatch();
		sw.Restart();
			var stud1 = students.FindByID(1);
		stud1.GroupId = 1000;
		WriteLine(stud1);
		sw.Stop();
		Console.WriteLine($"Time elapsed: {sw.Elapsed}\n");

		sw.Restart();
		var stud2 = students.FindByIIN(stud1.IIN);


		WriteLine(stud2);
		WriteLine();
		sw.Stop();
		Console.WriteLine($"Time elapsed: {sw.Elapsed}\n");
		var studList = Student.GetStudentWithGroupNameList(stufFileName, groupFileName, size);
		Utils.PrintListByLines(studList); 
	}

}
