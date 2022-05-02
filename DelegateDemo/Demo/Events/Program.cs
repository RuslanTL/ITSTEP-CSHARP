global using static System.Console;


namespace EventsNS;

public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

public class Item {
  string _name;
  decimal _price;

  public Item(string name) { _name = name; }

  public event PriceChangedHandler PriceChanged;
  //works too!!!
  //public PriceChangedHandler PriceChanged;


  public decimal Price {
    get { return _price; }
    set {
      if (_price == value) return;      // Exit if nothing has changed
      decimal oldPrice = _price;
      _price = value;
      if (PriceChanged != null)         // If invocation list not empty,
        PriceChanged(oldPrice, _price); // fire event.
    }
  }
}


class Program {
  static void ReportPriceChange(decimal oldPrice, decimal newPrice) {
    WriteLine($"Price changed from {oldPrice} to {newPrice}");
  }



  static void Main(string[] args) {
    var item = new Item("Microsoft");
    item.PriceChanged += ReportPriceChange;
    item.Price = 100;
    item.Price = 200;
    item.Price = 400;

    ReadLine();
  }
}
