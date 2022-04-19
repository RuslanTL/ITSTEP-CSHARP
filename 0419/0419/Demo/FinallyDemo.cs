using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DemoNS {
  class FinallyDemo {
    static void IntroDemo() {
      try {
        WriteLine("in try:");
        WriteLine("попытка деления на ноль");
        Calculator.CalcInt(0);
        WriteLine("не будет выполнено!");

      } catch (Exception ex) {
        WriteLine("\nin catch:");
        WriteLine("Обработка ошибки, информация об ошибке:");
        WriteLine(ex.Message);
      } finally {
        WriteLine("\nin finally:");
        WriteLine("Производится необходимая очистка, закрытие и т.п.");
      }
    }



    static void FinallySample() {
      string fileName = "file.txt";
      File.WriteAllText(fileName, $"Содержимое файла {fileName}");

      StreamReader reader = null;
      try {
        reader = File.OpenText(fileName);
        WriteLine(reader.ReadLine());
        reader.Read(null, 1, 1); // throws exception!

      } catch (Exception ex) {
        WriteLine(ex.Message);
      
      } finally {
        if (reader != null)
          reader.Dispose();
      }
    }



    //то же самое, но короче с помощью using
    static void Using() {
      string fileName = "file.txt";
      File.WriteAllText(fileName, $"Содержимое файла {fileName}");

      using (StreamReader reader = File.OpenText(fileName)) {
        try {
          WriteLine(reader.ReadLine());
          reader.Read(null, 1, 1); // throws exception!
        } catch (Exception ex) {
          WriteLine(ex.Message);
        }
      }
    }



    public static void Demo() {
      IntroDemo();

      //FinallySample();
      //Using();
    }
  }
}
