using System;
using static System.Console;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DemoNS {
  class OthersDemos {
    static void ExceptionFilters() {
      try {
        new WebClient().DownloadString("http://thisDoesNotExist");
        //new WebClient().DownloadString("https://translate.google.com");
      } catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout) {
        WriteLine("Timeout!");
      } catch (WebException ex) when (ex.Status == WebExceptionStatus.NameResolutionFailure) {
        WriteLine("Name resolution failure!");
      } catch (WebException ex) {
        WriteLine($"Some other failure: {ex.Status}");
      }
    }



    static void Checked() {
      int a = 1000000; int b = 1000000;
      int x = int.MaxValue;
      int c, y;

      //uncaught overflows:
      c = a * b;
      WriteLine(c);
      y = x + 1;
      WriteLine(y);

      //checks all expressions in statement block:
      checked {
        //the following code throws OverflowExceptions:
        c = a * b;
        WriteLine(c);
        y = x + 1;
        WriteLine(y);
      }

      //if checked in Advanced Build Settings
      unchecked {
        y = x + 1;
        WriteLine(y);
      }
    }



    public static void Demo() {
      //ExceptionFilters();
      Checked();
    }
  }
}
