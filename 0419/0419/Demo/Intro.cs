using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace DemoNS {
  class Intro {
    static void DivisionByZero() {
      //int x = Calculator.CalcInt(0);
      //WriteLine(x);

      //double y = Calculator.CalcDouble(0);
      //WriteLine(y);
      //WriteLine(double.IsInfinity(y));
      //double.IsNaN(y);
      //return;

      try {
        WriteLine("in try:");
        WriteLine("попытка деления на ноль");
        int z = Calculator.CalcInt(0);
        WriteLine("эта строчка не будет выполнена!");
        WriteLine(z);
      } catch (Exception ex) {
        WriteLine("\nin catch:");
        WriteLine("Обработка ошибки, информация об ошибке:");
        WriteLine(ex.Message);
      }
    }



    static void Catch() {
      try {
        byte b;
        string[] strArr = { "1", "2" };
        //throw new ArgumentNullException(nameof(Catch));

        //b = byte.Parse("qwerty");
        //b = byte.Parse(strArr [10]);
        b = byte.Parse("256");
        //b = byte.Parse("255");
        WriteLine(b);
      } catch (IndexOutOfRangeException ex) {
        WriteLine(ex.Message);
      } catch (FormatException ex) {
        WriteLine("That's not a number!");
        WriteLine(ex.Message);
      } catch (OverflowException ex) {
        WriteLine("You've given me more than a byte!");
        WriteLine(ex.Message);
      } catch (Exception ex) {
        WriteLine("All others exceptions!");
        WriteLine(ex.Message);
      }
    }



    public static void Demo() {
      //DivisionByZero();
      Catch();
    }
  }
}
