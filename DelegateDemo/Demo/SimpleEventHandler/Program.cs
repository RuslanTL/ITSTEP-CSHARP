namespace SimpleEventHandler;

public class Item {
  string _name;
  decimal _price;

  public Item(string name) { name = name; }

  public event EventHandler PriceChanged;


  protected virtual void OnPriceChanged(EventArgs e) {
    PriceChanged?.Invoke(this, e); //null-conditional operator
                                   //instead of:
                                   //if (PriceChanged != null) PriceChanged(this, e);
  }


  public decimal Price {
    get { return _price; }
    set {
      if (_price == value) return;
      _price = value;
      OnPriceChanged(EventArgs.Empty);
    }
  }
}



class Program {
  static void Stock_PriceChanged(object sender, EventArgs e) {
    Console.WriteLine($"New price = {((Item)sender).Price}");
  }



  static void Main(string[] args) {
    Item stock = new Item("THPW");
    stock.Price = 27.10M;
    // Register with the PriceChanged event
    stock.PriceChanged += Stock_PriceChanged;
    stock.Price = 31.59M;
    stock.Price = 41;

    Console.ReadLine();
  }
}

