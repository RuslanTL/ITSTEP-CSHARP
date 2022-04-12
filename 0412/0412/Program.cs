global using static System.Console;


namespace DemoNS
{

  class DemoNS
  {

    static void Types()
    {
      //Signed integer (sbyte, short, int, long)  // int32_t, int64_t, ...
      //Unsigned integer (byte, ushort, uint, ulong)
      //Real number (float, double, decimal)
      int i = 123;
      WriteLine($"sizeof(int) = {sizeof(int)}");
      // do for all ...

      WriteLine($"sizeof(char) = {sizeof(char)}");
      //WriteLine($"sizeof(string) = {sizeof(string)}");
      
      WriteLine($"int.MaxValue = {int.MaxValue}");
      WriteLine($"int.MinValue = {int.MinValue}");
      WriteLine($"double.MaxValue = {double.MaxValue}");
      WriteLine($"double.MinValue = {double.MinValue}");
    }



    public struct PointStruct
    {
      public int X;
      public int Y;
    }


    public class PointClass
    {
      public int X;
      public int Y;
    }


    static void ValueTypes()
    {
      PointStruct p1 = new PointStruct();
      WriteLine("Value type (struct)");
      p1.X = 1;
      PointStruct p2 = p1;      // Assignment causes copy
      WriteLine("before:");
      WriteLine(p1.X);  // 1
      WriteLine(p2.X);  // 1
      WriteLine("after:");
      p1.X = 100;       // Change p1.X
      WriteLine(p1.X);  // 100
      WriteLine(p2.X);  // 1
      WriteLine();
    }




    static void ReferenceTypes()
    {
      WriteLine("Value type (class)");
      PointClass p1 = new PointClass();
      p1.X = 1;
      PointClass p2;
      p2 = p1; // Copies p1 reference
      WriteLine("before:");
      WriteLine(p1.X);    // 1
      WriteLine(p2.X);    // 1
      WriteLine();
      p1.X = 100;         // Change p1.X
      WriteLine("after:");
      WriteLine(p1.X);    // 100
      WriteLine(p2.X);    // 100
      WriteLine();
    }



    static void NumericLiterals()
    {
      int x = 127;
      long y = 0x7L;
      int millionInt = 1_000_000;
      var b = 0b1010_1011_1100_1101_1110_1111;
      double d = 1.5;
      double million = 1E06;
      double oneMillionth = 1E-06;

      //Numeric suffixes
      float f = 1.0F;
      double x2 = 1D;
      decimal d2 = 1.0M;
      uint ui = 1U;
      long li = 11L;
      ulong ui2 = 222UL;

      var ui3 = 333UL; ;
      WriteLine($"{ui2} {ui3}");
    }




    static void ArrayDemo()
    {
      int size = 1_000_000;
      double[] arr = new double[size];
      var rnd = new Random(0);
      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = rnd.NextDouble();
      }

      for (int i = 0; i < 10; i++)
      {
        Write($"{arr[i],6:N2}");
      }
      WriteLine();
      for (int i = arr.Length - 10; i < arr.Length; i++)
      {
        Write($"{arr[i],6:N2}");
      }
      WriteLine();

      WriteLine($"arr.Rank (dimension) = {arr.Rank}");
      WriteLine($"arr.Length = {arr.Length}");

      //Simplified initialization expressions
      long[] longs = { 1, 20, 300 };
      char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    }



    static void MatrixDemo()
    {
      double[,] arr = new double[2, 10];
      int dimension = arr.Rank;
      WriteLine($"Dimention = {dimension}");

      int rows = arr.GetLength(0);
      WriteLine($"rows = {rows}");
      int cols = arr.GetLength(1);
      WriteLine($"cols = {cols}");

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          arr[i, j] = 100 * i + j;
        }
      }
    }



    static void Conversion()
    {
      int x = 12345;       // int is a 32-bit integer
      long y = x;          // Implicit conversion to 64-bit integer
      short z = (short)x;  // Explicit conversion to 16-bit integer
      WriteLine($"{y}");
      WriteLine($"{z}");
      //check with greater!
    }



    static void Main(string[] args)
    {
      try
      {
        //Types();
        //ValueTypes();
        //ReferenceTypes();
        //NumericLiterals();
        //ArrayDemo();
        //MatrixDemo();
        //Conversion();

     
        RandomDemo.RandomNumbersDemo();

      }
      catch (Exception ex)
      {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd ...");
      ReadLine();
    }
  }
}
