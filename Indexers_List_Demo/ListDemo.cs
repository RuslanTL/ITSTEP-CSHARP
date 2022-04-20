
using System;
using static System.Console;
using UtilsNS;
using System.Collections.Generic;
using System.Linq;

namespace DemoNS {
  class ListDemo {

    static void ListFirstDemo() {
      var list = new List<double>() { 1, 4, 3, 2 };
      for (int i = 0; i < list.Count; i++) {
        list[i] = i; //indexer! 
      }
      for (int i = 0; i < list.Count; i++) {
        WriteLine(list[i]); //indexer! 
      }
    }


    static void IntroToList() {
      int size = 1_000_000;
      var list = new List<long>();
      for (int i = 0; i < size; i++) {
        list.Add(i * 10);
      }
      Utils.PrintList(list);
      WriteLine($"Размер list = {list.Count}");
      WriteLine();

      List<string> strList = new List<string> { "Превед", "медвед", "!" };
      Utils.PrintList(strList, 10);
      WriteLine();

      //retrieve List elements
      for (int i = 0; i < strList.Count; i++) {
        WriteLine(strList[i]);
      }
      //or:
      WriteLine();
      foreach (var item in strList) {
        WriteLine(item);
      }

      //Insert List elements
      strList.Insert(1, "(hello)");
      Utils.PrintList(strList, 10);

      //Remove List elements
      strList.Remove("(hello)");
      //or
      //strList.RemoveAt(1);
      Utils.PrintList(strList, 10);


      //Contains
      WriteLine(strList.Contains("медвед"));

      //Find
      WriteLine(strList.Find(p => p.Length == 6));

      //IndexOf
      WriteLine(strList.IndexOf("медвед"));

      //Sort
      //Array.Sort(arr);
      strList.Sort();
      Utils.PrintList(strList, 10);

      //Clear
      strList.Clear();
      Utils.PrintList(strList, 10);
    }



    static void CopyDemo() {
      //Array To List
      string[] strArr = new string[3];
      strArr[0] = "Red";
      strArr[1] = "Blue";
      strArr[2] = "Green";
      //here to copy array to List
      var list = new List<string>(strArr);
      Utils.PrintList(list);
      WriteLine();

      list.Add("Yellow");
      Utils.PrintList(list);
      WriteLine();

      string[] newArr = list.ToArray();
      Utils.PrintArray(newArr);
    }



    public static void Demo() {
      //ListFirstDemo();
      IntroToList();
      CopyDemo();
    }
  }
}
