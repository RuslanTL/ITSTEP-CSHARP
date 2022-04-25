namespace NestedOuter {
  namespace NestedInner {
    public class MyClass {
      public int IIN { get; set; }
    }
  }
}


namespace Outer.Middle.Inner {
  class Class1 { }
  class Class2 { }
}

//or:
namespace Outer {
  namespace Middle {
    namespace Inner {
      class Class3 { }
      class Class4 { }
    }
  }
}



//Repeated namespaces:
namespace Outer.Middle.Inner {
  class Class5 { }
}