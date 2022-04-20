using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  class Program {

    static void StringDemo() {
      string s = "hello";
      WriteLine(s[0]);
      WriteLine(s[3]);
      WriteLine();
    }




    static void PersonsDemo() {
      Person[] persArr = {
        new Person { PersonID = 10, IIN = "111111111111", LastName = "Smith", FirstName = "Sean" },
        new Person { PersonID = 5, IIN = "222222222222", LastName = "Karimov", FirstName = "Karim" },
        new Person { PersonID = 4, IIN = "333333333333", LastName = "Ivanov", FirstName = "Ivan" },
        new Person { PersonID = 20, IIN = "", LastName = "Borisov", FirstName = "Boris" },
        new Person { PersonID = 15, IIN = "555555555555", LastName = "Abramov", FirstName = "Abram" },
      };

      var persons = new Persons(persArr);
      Person person; long newId = 444; string newLastName = "Abaev", newFirstName = "Abai";
      Person newPerson = new Person { PersonID = newId, LastName = newLastName, FirstName = newFirstName };

      person = persons[5];
      Console.WriteLine($"{person}");
      persons[5] = newPerson;
      person = persons[newId];
      WriteLine($"{person}");

      //by students - indexer by IIN:
      //person = persons["444444444444"];
      //WriteLine($"{person}");
      //persons["444444444444"] = newPerson;
      //person = persons[newLastName];
      //WriteLine($"{person}");
    }



    static void MatrixDemo() {
      var m = new Matrix(100, 200);
      m[10, 20] = 200;
      WriteLine($"m[10, 20] = {m[10, 20]}");
    }

    static void Demo1() {
      WriteLine("list 1: \n");
      var list1 = UtilsNS.Utils.GetIntList(8,0,100);
      UtilsNS.Utils.PrintList(list1);
      WriteLine("\nlist 2: \n");
      var list2 = UtilsNS.Utils.GetSomeEvensList(25);
      UtilsNS.Utils.PrintList(list2);

      WriteLine("\n-----------------------------------\narr 1: \n");
      var arr1 = UtilsNS.Utils.GetIntArray(100, 1, 100);
      UtilsNS.Utils.PrintArray(arr1);
      UtilsNS.Utils.GetOddEvenArrays(arr1);

      WriteLine("\n-----------------------------------\narr 2: \n");
      var arr2 = UtilsNS.Utils.GetIntArray(50, 1, 100);
      UtilsNS.Utils.PrintArray(arr2);
      UtilsNS.Utils.GetOddEvenLists(arr2);

      WriteLine("\n-----------------------------------\narr 3: \n");
      var arr3 = UtilsNS.Utils.GetIntArray(50, 1, 100);
      UtilsNS.Utils.PrintArray(arr3);
      UtilsNS.Utils.GetSomeLists(arr3, 20);
    }



    static void Main(string[] args) {
      try {
        //Sentence.Demo();
        //StringDemo();
        //PersonsDemo();
        //MatrixDemo();

        //ListDemo.Demo();
        Demo1();

      } catch (Exception ex) {
        WriteLine(ex);
      }
      ReadLine();
    }
  }
}
