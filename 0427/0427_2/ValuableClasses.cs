using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0427_2 {
  class Book : IValuable {
    public double _value { get=>_value*=1.1; set { _value = value; } }
    public Book(double val) {
      _value = val;
    }

  }

  class Picture : IValuable {
    public double _value { get => _value *= 1.1; set { _value = value; } }
    public Picture(double val) {
      _value = val;
    }
  }

  class Statue : IValuable {
    public double _value { get => _value *= 1.1; set { _value = value; } }
    public Statue(double val) {
      _value = val;
    }

  }

  class Rarity : IValuable {
    public double _value { get => _value *= 1.1; set { _value = value; } }
    public Rarity(double val) {
      _value = val;
    }

  }
}
