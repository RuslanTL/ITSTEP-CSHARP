namespace DemoNS
{
  class RandomDemo
  {

    static void RandomIntro()
    {
      //Random rnd = new Random();
      Random rnd = new Random(0);
      int n = rnd.Next();
      double d = rnd.NextDouble();
      WriteLine(n);
      WriteLine(d);
    }



    static void RandomNumbers(bool newSeed)
    {
      Random rnd;
      for (int i = 0; i < 2; i++)
      {
        Thread.Sleep(500);
        if (newSeed)
          rnd = new Random();
        else
          rnd = new Random(0);

        for (int j = 0; j < 20; j++)
        {
          Console.Write($"{rnd.Next(0, 100)} ");
        }
        WriteLine();
      }
    }



    public static void RandomNumbersDemo()
    {
      //RandomIntro();

      WriteLine($"Разные:");
      RandomNumbers(true);

      WriteLine($"\nОдинаковые:");
      RandomNumbers(false);
    }
  }
}
