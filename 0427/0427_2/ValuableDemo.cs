using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0427_2 {
  public static class ValuableDemo {
    public static List<IValuable> GeRandomValuableList(int size) {
      var valuables = new List<IValuable>();
      var rnd = new Random();
      double pick;
      for (int i = 0; i < size; i++) {
        pick = rnd.NextDouble();
        if (pick < 0.25) {
          valuables.Add(new Book(pick * 100));
        } else if (pick < 0.5) {
          valuables.Add(new Picture(pick * 100));
        } else if (pick < 0.75) {
          valuables.Add(new Statue(pick * 100));
        } else {
          valuables.Add(new Rarity(pick * 100));
        }
      }
      return valuables;
    }
    public static double GetWorth(IValuable v) {
      return v._value;
    }
    public static double GetWorth(List<IValuable> list) {
      double worthSum = 0;
      foreach (IValuable item in list) {
        worthSum += GetWorth(item);
      }
      return worthSum;
    }

    public static int CompareByValue(IValuable a, IValuable b) {
      return -a._value.CompareTo(b._value);
    }
    public static void SortByValue(List<IValuable> list) {
      list.Sort(CompareByValue);
    }

  }
}
