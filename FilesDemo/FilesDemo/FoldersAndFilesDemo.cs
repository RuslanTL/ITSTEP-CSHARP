namespace DemoNS;

class FoldersAndFilesDemo {
  public static void Demo() {
    string path = @"Z:\csharp";

    //files only
    string[] files = Directory.GetFiles(path, "*problem*.txt", SearchOption.AllDirectories);
    foreach (var file in files) {
      WriteLine(file);
    }
    WriteLine();
    WriteLine();

    //folders only
    string[] folders = Directory.GetDirectories(path, "*problem*", SearchOption.AllDirectories);
    foreach (var folder in folders) {
      WriteLine(folder);
    }
    WriteLine();
    WriteLine();

    //files and folders
    string[] fileEntries = Directory.GetFileSystemEntries(path, "*problem*", SearchOption.AllDirectories);
    foreach (var fileEntry in fileEntries) {
      WriteLine(fileEntry);
    }
  }
}



class DirectoryInfoDemo {
  public static void Demo() {
    string path = @"Z:\csharp";
    DirectoryInfo info = new DirectoryInfo(path);
    var files = info.GetFiles("*problem*", SearchOption.AllDirectories).OrderBy(p => p.CreationTime).ThenBy(p => p.Name);
    foreach (FileInfo file in files) {
      WriteLine($"{file.CreationTime}{file.Length,12}\t{file.Name}");
    }
  }
}


class DirectoryDemo {
  public static void Demo() {
    string path = @"C:\_2";
    Directory.CreateDirectory(path);
    WriteLine(Directory.Exists(path));
    Directory.Delete(path);
    WriteLine(Directory.Exists(path));
  }
}