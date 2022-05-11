using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Problem 03 - ReplaceInFile
Напишите программу, создающую файл ReplaceInFile.exe, при запуске которого с параметрами
ReplaceInFile.exe oldFileName, newFileName, oldSubString, newSubString
происходит создание файла newFileName, в котором все подстроки (слова, в частности) oldSubString заменены на newSubString.
Например:
ReplaceInFile.exe "C:\_0\Война и мир - UTF-8.txt", "Война и мир - new.txt", "CHAPTER  ", "ГЛАВА - "

ДОПОЛНИТЕЛЬНО
В случае запуска с ТРЕМЯ параметрами
ReplaceInFile.exe fileName, oldSubString, newSubString
Происходит переписывание файла fileName с осуществленной заменой подстрок.*/

namespace Test {
  internal class ReplaceInFileDemo {
    static void ReplaceInFile(string oldFile, string newFile, string oldSub, string newSub) {
      using (var file = new StreamReader(oldFile)) {
        using (var file2 = new StreamWriter(newFile)) {
          Console.WriteLine("new file created");
          string line;
          string output = "";
          int subs = 0;
          while ((line = file.ReadLine()) != null) {
            file2.WriteLine(line.Replace(oldSub, newSub));
          }
          
        }
        Console.WriteLine();
        Console.WriteLine("reading finished");
        
      }
    }
    static void ReplaceInFile(string _file, string oldSub, string newSub) {
      string output = "";
      using (var file = new StreamReader(_file)) {
        string line;
        while ((line = file.ReadLine()) != null) {
          output += $"{line.Replace(oldSub, newSub)}\n";
        }
      }
      using (var file2 = new StreamWriter(_file)) {
        Console.WriteLine("file overwrite");
        file2.Write(output);
      }
    }
    public static void Main(string[] args) {
      //ReplaceInFile.exe "C:\_0\War and Peace - UTF-8.txt" "NewBook.txt" "CHAPTER " "HELLO --" - 4 args
      //replace all CHAPTER with HELLO and write to copy "NewBook.txt"

      //ReplaceInFile.exe "test.txt" "world" "earth" - 3 args
      //replace all "world" with "earth" and overwrite "test.txt"
      Console.WriteLine("program started");
      string oldFileName, oldSubString, newSubString;
      string fileName;
      string newFileName = " ";
      if (args.Length == 4) {
        oldFileName = args[0];
        newFileName = args[1];
        oldSubString = args[2];
        newSubString = args[3];
        Console.WriteLine("arguments loaded");


        ReplaceInFile(oldFileName, newFileName, oldSubString, newSubString);
      } else if(args.Length == 3) {
        fileName = args[0];
        oldSubString = args[1];
        newSubString = args[2];
        Console.WriteLine("arguments loaded");
        ReplaceInFile(fileName, oldSubString, newSubString);
      } else {
        throw new ArgumentException("must have 3 or 4 arguments!");
      }

  
    }
  }
}
