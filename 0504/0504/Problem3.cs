using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Problem 03 
Подсчитайте по отдельности количества уникальных StudentID, групп, ИИН, фамилий, имен и дат рождения в файле students_10_000_000.txt.*/
namespace _0504 {
  class Problem3 {
    public static void Demo() {
      string fileName = @"C:\_0\students_10_000_000.txt";
      Console.WriteLine("file read begin");
      var students = StudentsNS.Student.GetStudentList(fileName, 1000000);
      var IINMap = new HashSet<string>();
      var lastNamesMap = new HashSet<string>();
      var firstNamesMap = new HashSet<string>();
      var birthdaysMap = new HashSet<DateTime>();
      foreach(StudentsNS.Student item in students) {
        IINMap.Add(item.IIN);
        lastNamesMap.Add(item.LastName);
        firstNamesMap.Add(item.FirstName);
        birthdaysMap.Add(item.Birthday);
      }
      Console.WriteLine($"Unique IINs in students: {IINMap.Count()}");
      Console.WriteLine($"Unique last names in students: {lastNamesMap.Count()}");
      Console.WriteLine($"Unique first names in students: {firstNamesMap.Count()}");
      Console.WriteLine($"Unique birthdays in students: {birthdaysMap.Count()}");


    }
  }
}
