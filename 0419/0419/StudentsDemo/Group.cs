using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace StudentsNS {
  class Group {
    public long GroupId { get; set; }
    public string GroupName { get; set; }

    public override string ToString() {
      return $"{GroupId} {GroupName}";
    }


    private static Group GetGroupFromLine(string line) {
      string[] words = line.Split('\t');
      long groupId = Int64.Parse(words[0]);
      return new Group() { GroupId = groupId, GroupName = words[1] };
    }



    public static Group[] GetGroupsArr(string fileName, int size = 1_000_000) {
      Group[] groups = new Group[size];
      using (var file = new StreamReader(fileName)) {
        string line;
        int count = 0;
        while ((line = file.ReadLine()) != null) {
          groups[count++] = GetGroupFromLine(line);

          //Group group = GetGroupFromLine(line);
          //groups[count] = group;
          //count++;
          if (count == size)
            break;
        }
      }
      return groups;
    }



    public static List<Group> GetGroupsList(string fileName, int size = 1_000_000) {
      List<Group> groups = new List<Group>();
      using (var file = new StreamReader(fileName)) {
        string line;
        int count = 0;
        while ((line = file.ReadLine()) != null) {
          groups.Add(GetGroupFromLine(line));
          if (count == size)
            break;
        }
      }
      return groups;
    }


    public static void PrintArray(Group[] arr) {
      //WriteLine(arr[0]);
      //WriteLine(arr[1]);
      //by students:
      // если больше 8, то первые 4, строка многоточий, последние 4
      // . . .
      if (arr.Length <= 8) {
        for (int i = 0; i < arr.Length; i++) {
          WriteLine(arr[i]);
        }
      } else {
        for (int i = 0; i < 4; i++) {
          WriteLine(arr[i]);
        }
        WriteLine(". . .");
        for (int i = arr.Length - 4; i < arr.Length; i++) {
          WriteLine(arr[i]);
        }
      }
    }
  
  }
}
