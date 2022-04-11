// See https://aka.ms/new-console-template for more information


//    Problem 01
// Напишише программу, принимающую 4 параметра командной строки, первые два из которых которые должны быть целыми числами, а последние -
// вещественными.Уведомляйте пользователей о возможных ошибках, как то:
// - число параметров не равно 4;
// - параметры не удовлетворяют требованиям и т.п.

global using static System.Console;



//Problem 04
//Напишите программу copyAndCount.exe, которая при запуске с двумя параметрами:
//copyAndCount.exe fileName1 fileName2
//производит построчное копирование существующего текстового файла fileName1 в новый fileName2 с выводом на консоль количества имеющихся строк и символов в fileName1.


class Program
{
  static void CopyAndCount(string f1)
  {
    using (var file = new StreamReader(f1))
    {
      using (var newFile = new StreamWriter("file2.txt"))
      {
        string line;
        int lineCount = 0;
        int charCount = 0;
        while ((line = file.ReadLine()) != null)
        {
          newFile.WriteLine(line);
          WriteLine($"line written into new file: ${line}");
          lineCount++;
          foreach (char c in line)
          {
            charCount++;
          }


        }
        WriteLine($"Amount of lines: {lineCount}");
        WriteLine($"Amount of characters: {charCount}");
      }


    }
  }
  static void CheckNumbers(string[] args)
  {

    //    Problem 01
    //Напишише программу, принимающую 4 параметра командной строки,
    //первые два из которых которые должны быть целыми числами, а последние -вещественными.Уведомляйте пользователей о возможных ошибках, как то:
    //    -число параметров не равно 4;
    //    -параметры не удовлетворяют требованиям и т.п.

    if (args.Length != 4)
    {
      WriteLine("the amount of parameters must be 4!");
      return;
    }

    bool result;
    int n1, n2; double d1, d2;
    result = int.TryParse(args[0], out n1);
    if (!result)
    {
      WriteLine("the first parameter is not an integer!");
      return;
    }
    result = int.TryParse(args[1], out n2);
    if (!result)
    {
      WriteLine("the second parameter is not an integer!");
      return;
    }
    result = double.TryParse(args[2], out d1);
    if (!result)
    {
      WriteLine("the third parameter is not a double!");
      return;
    }
    result = double.TryParse(args[3], out d2);
    if (!result)
    {
      WriteLine("the fourth parameter is not a double");
      return;
    }
    WriteLine("all parameters are correct");
    return;

  }
  static void Temp()
  {
    int size = 10;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
      WriteLine($"Enter number {i}: ");
      string s = ReadLine();
      int.TryParse(s, out var n);
      arr[i] = n;
    }
  }
  static void Main(string[] args)
  {
    //CopyAndCount("file1.txt");
    CheckNumbers(args);
  }
}