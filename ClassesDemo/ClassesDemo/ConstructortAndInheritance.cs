using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  public class Baseclass {
    public int Age;

    public Baseclass() { }

    public Baseclass(int age) {
      this.Age = age;
    }
  }



  public class Subclass : Baseclass {
    public double Weight;
    public Subclass(int age, double weight) : base(age) {
      this.Weight = weight;
    }


    public override string ToString() {
      return $"Age = {Age}, Weight = {Weight}";
    }
  }




}
