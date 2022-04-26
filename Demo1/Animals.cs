using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  class Animal {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Weight { get; set; }


    public Animal() {
      Id = Guid.NewGuid();
    }


    public void InfoNonVirt() {
      Console.WriteLine($"A am Animal - Name: {Name}, Id: {Id}");
    }


    public virtual void InfoVirt() {
      Console.WriteLine($"A am Animal - Name: {Name}, Id: {Id}");
    }


    public override string ToString() {
      return $"Name: {Name}";
    }


		public virtual void SayHello() {
			Console.WriteLine("Превед, Animal!");
		}
  }



  class Bear : Animal{
    public new void InfoNonVirt() {
      Console.WriteLine($"A am Bear - Name: {Name}, Id: {Id}");
    }

		public override void InfoVirt() {
			Console.WriteLine($"A am Bear - Name: {Name}, Id: {Id}");
		}


		public override void SayHello() {
			Console.WriteLine("Превед, Медвед!");
		}
	}



	class Cat : Animal {
		public new void InfoNonVirt() {
			Console.WriteLine($"A am Cat - Name: {Name}, Id: {Id}");
		}

		public override void InfoVirt() {
			Console.WriteLine($"A am Car - Name: {Name}, Id: {Id}");
		}


		public override void SayHello() {
			Console.WriteLine("Превед, Кот!");
		}
	}
}
