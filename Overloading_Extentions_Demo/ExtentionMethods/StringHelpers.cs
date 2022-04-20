using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  public static class StringHelpers {
    public static bool IsCapitalized(this string s) {
      if (string.IsNullOrEmpty(s))
        return false;
      return char.IsUpper(s[0]);
    }

        /*  Problem 01
    Написать extention method для класса string HelloTo().
    Например:
    WriteLine("Pooh".HelloTo());
    WriteLine(studentName.HelloTo());
    WriteLine("Пятачок".HelloTo());
    */  

    public static string HelloTo(this string s) {
      return $"Hello to {s}!";
    }

    public static string Capitalize(this string s) {
      if (string.IsNullOrEmpty(s))
        return String.Empty;
      if (s.IsCapitalized()) {
        return s;
      } else {
        //return s.First().ToString().ToUpper() + s.Substring(1);
        return s[0].ToString().ToUpper() + s.Substring(1);
      }
    }
  }

}
