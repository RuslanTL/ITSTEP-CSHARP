// See https://aka.ms/new-console-template for more informationC
global using static System.Console;

class Program
{
  //  Problem 02
  //Каждый параметр командной строки начинаются с --, за ним следует его значение(значение может отсутствовать - см пример!)
  //program.exe --param1 value1 --param2  --param3 value3. . .
  //Получите имена параметров и их значения (как строки).
  //Выведите их попарно на консоль.Например:
  //--param1: value1
  //--param2
  //--param3: value3
  //...

  //program.exe --x 10 --info  --y 20
  //--x: 10
  //--info
  //--y: 20

  //program.exe --x 10 --info --demo --y 20
  //--x: 10
  //--info
  //--demo
  //--y: 20
  static void printParams(string[] args)
  {
    if (args[0].StartsWith("--"))
    {

    }
  }
  //Problem 03
  //Прочитайте текстовый файл, созданный WriteNumbersToTextFile() и выведите  построчно первое, второе число и их произведение в каждой строке файла.
  // - на консоль;
  // - в файл c названиием "Problem_3.txt".
  //Числа должны быть выровнены по правому краю.
  static void WriteNumbersToTextFile()
  {
    using (var file = new StreamWriter("Problem_3.txt"))
    {
      for (int i = 0; i < 10; i++)
      {
        double x = i * i + 0.1;
        file.WriteLine($"{i}; {x}");
      }
    }
    WriteLine("File has been written");

    //or with using declarations
    //using var file2 = new StreamWriter("file1.txt");
    //for (int i = 0; i < 10; i++)
    //{
    //  double x = i * i + 0.1;
    //  file2.WriteLine($"{i}; {x}");
    //}
    //WriteLine("File has been written");
  }


  static void Main(int[] args)
  {

  }
}