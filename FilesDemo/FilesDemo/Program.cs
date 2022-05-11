global using static System.Console;

namespace DemoNS;

class Program {
  static void Main(string[] args) {
    try {
      //Path
      //DriveInfo

      //Directory
      //File

      //DirectoryInfo
      //FileInfo

      //PathDemo.Demo();
      FoldersAndFilesDemo.Demo();
      DirectoryInfoDemo.Demo();
      DirectoryDemo.Demo();
      //Binary_Demo.Demo();
      //Binary_Person.Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    Write("\nEnd  . . .");
    ReadLine();
  }
}

