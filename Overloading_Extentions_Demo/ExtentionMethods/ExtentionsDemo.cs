using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  class ExtentionsDemo {

    public static void Demo() {
      string pooh = "pooh";
      WriteLine("pooh".IsCapitalized());
      WriteLine(pooh.IsCapitalized());
      WriteLine("Pooh".IsCapitalized());
      WriteLine("pooh".Capitalize());

      WriteLine("Pooh".HelloTo());

      // exact equivalent to:
      WriteLine(StringHelpers.IsCapitalized("Pooh"));
      WriteLine();


      string qwerty = "qwerty";
      WriteLine(qwerty.IsCapitalized());
      WriteLine(qwerty.Capitalize().IsCapitalized());
      WriteLine();

      
      string s = "null";
      WriteLine(s?.ToUpper());
      WriteLine(s?.IsCapitalized());
    }

  }
}
