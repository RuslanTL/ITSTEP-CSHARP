using System;
using static System.Console;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DemoNS {
  class ThrowingDemo {
    static void Display(string info) {
      if (info == null)
        throw new Exception("Help!!");
      WriteLine(info);
    }


    static void Throwing() {
      try {
        Display(null);
      } catch (Exception ex) {
        WriteLine("Caught the exception:");
        WriteLine(ex.Message);
      }
    }



    static void ReThrowing() {
      string s = null;
      using (WebClient wc = new WebClient()) {
        try {
          s = wc.DownloadString("http://www.qqq.com");
        } catch (WebException ex) {
          if (ex.Status == WebExceptionStatus.NameResolutionFailure) {
            WriteLine(ex.Message);
            WriteLine("Делаем что-нибудь для обработки Exception . . .");
            throw;
          } else {
            throw;   // Can’t handle other sorts of WebException, so rethrow
          }
        }
      }
    }



    public static void Demo() {
      //Throwing();
      ReThrowing();
    }
  }
}
