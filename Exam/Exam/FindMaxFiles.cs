using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam {
  /*Problem 04 (дополнительно)
В папке "C:\Program Files (x86)" найдите папку верхнего уровня, содержащую наибольшее количество файлов в себе и в собственных подпапках*/
  internal class FindMaxFilesDemo {
    static KeyValuePair<DirectoryInfo,long> findMaxFiles(string path) {
      var directory = new DirectoryInfo(path);
      var subDirectories = directory.GetDirectories();
      Console.WriteLine($"directories in folder {directory.Name}: {subDirectories.Count()}");
      var dirFileCount = new Dictionary<DirectoryInfo, long>();
      foreach(DirectoryInfo dir in subDirectories) {
        try {
          dirFileCount.Add(dir, dir.EnumerateFiles("*", SearchOption.AllDirectories).Count());
        }catch(UnauthorizedAccessException ex) {
          Console.WriteLine("protected file unable to be added!");
        }

      }
      DirectoryInfo max = dirFileCount.ElementAt(0).Key;
      foreach(KeyValuePair<DirectoryInfo,long>pair in dirFileCount) {
        if (pair.Value > dirFileCount[max]) {
          max = pair.Key;
        }
        Console.WriteLine($"{pair.Key.Name}: {pair.Value} files");
      }
      return new KeyValuePair<DirectoryInfo,long>(max,dirFileCount[max]);
    }

    public static void Demo() {
      //C:\Program Files (x86)" слишком долго считает
      string path = @"C:\Program Files (x86)\Common Files";
      KeyValuePair<DirectoryInfo,long> biggestFolder = findMaxFiles(path);
      Console.WriteLine($"\nBiggest folder: \n{biggestFolder.Key.Name}: {biggestFolder.Value} files");
    }
  }
}
