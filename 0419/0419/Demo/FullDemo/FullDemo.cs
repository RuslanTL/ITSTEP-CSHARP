using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace DemoNS {
  class FullDemo {

    static void C(int i) {
      try {
        WriteLine($"Method C() called with {i}");
        
        if(i == 0)
          throw new CatExcep("Hello the Cat (from CatExcep)!");
        if (i == 1)
          throw new BearExcep("Hello the Bear (from BearExcep)!");
        if (i == 2)
          throw new AnimalExcep("Hello the Animal (from AnimalExcep)!");
        if (i == 4)
          throw new OutsideExcep("Hello from OutsideExcep (caught in Main)!");
        

      } catch (CatExcep ex) {
        WriteLine($"{ex.Message}");
      } finally {
        WriteLine("Freeing resources in method C()");
      }
    }


    static void B(int i) {
      try {
        WriteLine($"Method B() called with {i}");
        C(i);
      } catch (BearExcep ex) {
        WriteLine($"{ex.Message}");
      } finally {
        WriteLine("Freeing resources in method B()");
      }
    }


    static void A(int i) {
      try {
        WriteLine($"Method A() called with {i}");
        B(i);
      } catch (AnimalExcep ex) {
        WriteLine($"{ex.Message}");
      } finally {
        WriteLine("Freeing resources in method A()");
      }
    }



    public static void Demo() {
      // i = 5 не выполняется!
      for (int i = 0; i < 6; i++) {
        A(i);
        WriteLine("\n");
      }
    }
  }
}
