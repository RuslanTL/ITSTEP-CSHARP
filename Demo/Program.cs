global using static System.Console;

namespace DemoNS
{

  class Program
  {
    const string _fileName = "demoFile.txt";

    static void CommandLine(string[] args)
    {
      //string param1 = args[0];
      //string param2 = args[2];

      for (int i = 0; i < args.Length; i++)
      {
        WriteLine(args[i]);
      }

      //or:
      foreach (var item in args)
      {
        WriteLine(item);
      }
    }



    static void ReadTwoNumbersFromString()
    {
      while (true)
      {
        WriteLine("Введите 2 целых числа в одной строке:");
        string input = Console.ReadLine();
        int n0, n1;

        //simple, if one space:
        //string[] words = input.Split(' ');

        //simple, if many spaces:
        //string[] words = input.Split(' ',  StringSplitOptions.RemoveEmptyEntries);

        //the best!
        string[] words = input.Split(new char[] { ' ', '\t', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length != 2)
        {
          WriteLine("Не введены 2 числа");
          continue;
        }
        bool result0 = int.TryParse(words[0], out n0);
        bool result1 = int.TryParse(words[1], out n1);
        if (result0 && result1)
        {
          WriteLine($"n0 = {n0}; n1 = {n1}");
        }
        else
        {
          WriteLine("Ошибка!");
        }
      }
    }




    static void WriteNumbersToTextFile()
    {
      using (var file = new StreamWriter(_fileName))
      {
        for (int i = 0; i < 10; i++)
        {
          double x = i * i + 0.1;
          file.WriteLine($"{i}; {x}");
        }
      }
      WriteLine("File has been written");

      //or with using declarations
      using var file2 = new StreamWriter(_fileName);
      for (int i = 0; i < 10; i++)
      {
        double x = i * i + 0.1;
        file2.WriteLine($"{i}; {x}");
      }
      WriteLine("File has been written");
    }



    static void ReadTextFile()
    {
      using (var file = new StreamReader(_fileName))
      {
        string line;
        while ((line = file.ReadLine()) != null)
        {
          WriteLine(line);
        }
      }
      WriteLine("File has been readed");
    }



    static void ReadNumbersFromTextFile()
    {
      using (var file = new StreamReader(_fileName))
      {
        int n1; double n2;
        string line;
        while ((line = file.ReadLine()) != null)
        {
          string[] tokens = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
          bool result0 = int.TryParse(tokens[0], out n1);
          bool result1 = double.TryParse(tokens[1], out n2);
          WriteLine($"{n1,5}{n2,6}{n1 * n2,10:N3}");
        }
      }
      WriteLine("File has been readed");
    }



    static void ReadAndWrite()
    {
      string fileInName = @"C:\_0\students_10_000_000.txt";
      string fileOutName = @"C:\_0\_temp.txt";

      using var inFile = new StreamReader(fileInName);
      using var outFile = new StreamWriter(fileOutName);
      string line;
      int counter = 0;
      while ((line = inFile.ReadLine()) != null)
      {
        outFile.WriteLine($"{counter}: {line}");
        counter++;
        if (counter == 10)
          break;
      }
    }



    static void Main(string[] args)
    {
      try
      {
        //CommandLine(args);

        ReadTwoNumbersFromString();

        //WriteNumbersToTextFile();
        //ReadTextFile();
        //ReadNumbersFromTextFile();

        //ReadAndWrite();

      }
      catch (Exception ex)
      {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd . . .");
      ReadLine();
    }
  }
}
