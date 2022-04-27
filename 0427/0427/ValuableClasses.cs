using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0427 {
  class Book : IValuable {
    double _value;
    public Book(double value) {
      _value = value;
    }
    public double GetValue() => _value * 1.1;
  }
  class Picture : IValuable {
    double _value;
    public Picture(double value) {
      _value = value;
    }
    public double GetValue() => _value * 1.1;
  }
  class Statue : IValuable {
    double _value;
    public Statue(double value) {
      _value = value;
    }
    public double GetValue() => _value * 1.1;
  }
  class Rarity : IValuable {
    double _value;
    public Rarity(double value) {
      _value = value;
    }
    public double GetValue() => _value * 1.1;
  }
}
