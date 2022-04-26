using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  public class Stack {
    int position;
    object[] _data = new object[100];


    public void Push(object obj) {
      _data[position++] = obj;
    }


    public object Pop() {
      return _data[--position];
    }
  }
}
