using System.Text;

namespace DemoNS;
class Binary_Demo {
  public static void Demo() {
    string fileTextUTF8Name = "demoUTF8.txt";
    string fileTextASCIIName = "demoASCII.txt";
    string fileBinName = "demoBIN.txt";
    string bearEng = "Winnie Pooh", bearRus = "Винни Пух";
    double d = 123.456;

    //unicode text file
    using (var file = new StreamWriter(fileTextUTF8Name)) {
      file.WriteLine(d);
      file.WriteLine(bearEng);
      file.WriteLine(bearRus);
    }

    //to show in win-1251!
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    Encoding.GetEncoding("Windows-1251");
    using (var file = new StreamWriter(File.Open(fileTextASCIIName, FileMode.Create), Encoding.GetEncoding("Windows-1251"))) {
      file.WriteLine(d);
      file.WriteLine(bearEng);
      file.WriteLine(bearRus);
    }


    //writing binary file
    using (var file = new BinaryWriter(File.Open(fileBinName, FileMode.Create))) {
      file.Write(d);
      file.Write(bearEng);
      file.Write(bearRus);
    }


    //reading binary file
    using (var file = new BinaryReader(File.Open(fileBinName, FileMode.Open))) {
      d = file.ReadDouble();
      bearEng = file.ReadString();
      bearRus = file.ReadString();

      WriteLine(d);
      WriteLine(new string(bearEng));
      WriteLine(new string(bearRus));
    }

  }
}

