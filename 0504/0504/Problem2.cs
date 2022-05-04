using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 02
Определите, когда начнут повторяться rnd.Next(int.MinValue, int.MaxValue) - с какого раза (timesBeforeFirstRepeat) и с какого числа (valueFirstRepeat).
Выведите на консоль результаты 100(?) измерений. Каждый раз создавайте новый new Random(i), где i - переменная цикла.
Выведите среднее значение timesBeforeFirstRepeat (количество вызовов rnd.Next до первого повторения).*/

namespace _0504 {
  class Problem2 {

    public static void Demo() {
      var timesList = new List<int>();
      for(int i =0; i<100; i++) {
        int timesBeforeFirstRepeat = 0;
        var rndHash = new HashSet<long>();
        var rndList = new List<long>();
        var rnd = new Random(i);
        while (rndHash.Count==rndList.Count) {
          timesBeforeFirstRepeat++;
          rndHash.Add(rnd.Next(int.MinValue, int.MaxValue));
          rndList.Add(rnd.Next(int.MinValue, int.MaxValue));
        }
        timesList.Add(timesBeforeFirstRepeat);
        long valueFirstRepeat = rndList[timesBeforeFirstRepeat-1];
        Console.WriteLine($"Repeat found on index {timesBeforeFirstRepeat}: {valueFirstRepeat}");

      }
      Console.WriteLine($"Average index of repeat value: {Math.Round(timesList.Average())}");
    }

  }
}
