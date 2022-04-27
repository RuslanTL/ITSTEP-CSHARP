using System.Collections;

namespace InterfacesNS {

  internal class Countdown : IEnumerator {
    int count = 11;
    public bool MoveNext() => count-- > 0;
    public object Current => count;
    public void Reset() { throw new NotSupportedException(); }
  }


  class EnumeratorDemo {

    public static void Demo() {
      IEnumerator e = new Countdown();
      while (e.MoveNext())
        Write($"{e.Current} ");
      WriteLine();


      int[] arr = { 10, 20, 30, 40 };
       
      IEnumerator arrEn = arr.GetEnumerator();
      while (arrEn.MoveNext())
        Write($"{arrEn.Current} ");
      WriteLine();

      //or - эквивалентно:
      foreach (var item in arr) {
        Write($"{item} ");
      }
    }
  }
}
