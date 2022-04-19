using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNS {
  public class AnimalExcep: Exception  {
    public AnimalExcep(string msg) : base(msg) {}
  }



  public class BearExcep : AnimalExcep {
    public BearExcep(string msg) : base(msg) { }
  }
  


  public class CatExcep : AnimalExcep {
    public CatExcep(string msg) : base(msg) { }
  }



  //derived  from Exception!!!
  public class OutsideExcep : Exception {
    public OutsideExcep(string msg) : base(msg) { }
  }
}
