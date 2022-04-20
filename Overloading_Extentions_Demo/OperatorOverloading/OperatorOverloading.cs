using System;
using static System.Console;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  public class Note {
    int _value;

    public Note(int semitonesFromA) {
      _value = semitonesFromA;
    }


    public static Note operator +(Note x, int semitones) {
      return new Note(x._value + semitones);
    }

    //Convert to hertz
    public static implicit operator double(Note x)
      => 440 * Math.Pow(2, (double)x._value / 12);

    // Convert from hertz (accurate to the nearest semitone)
    public static explicit operator Note(double x)
      => new Note((int)(0.5 + 12 * (Math.Log(x / 440) / Math.Log(2))));


    public override string ToString() {
      return $"Note = {_value}";
    }
  }



  class OperatorOverloadingDemo {
    static void Overloading() {
      Note b = new Note(2);
      Note cSharp = b + 2;
      WriteLine(cSharp); // to see! - may be compiler glitch (error?)
      WriteLine(cSharp.ToString());
    }



    static void Conversion() {
      Note n = (Note)554.37;  // explicit conversion
      double x = n;           // implicit conversion
      WriteLine(n.ToString());
      WriteLine(x);
    }



    public static void Demo() {
      Overloading();
      Conversion();
    }
  }
}
