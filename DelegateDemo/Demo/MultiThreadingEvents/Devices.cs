namespace DemoNS;

public delegate void ValueChangedHandler(int deviceNumber, double oldValue, double newValue);

class Device {
  public event ValueChangedHandler ValueChanged;
  int _deviceNumber;
  double _value;
  Random _rnd = new Random();

  public Device(int deviceNumber, double initValue) {
    _deviceNumber = deviceNumber;
    Value = initValue;
  }


  double Value {
    get {
      return _value;
    }
    set {
      if (_value != value) {
        if (ValueChanged != null)
          ValueChanged(_deviceNumber, _value, value);
        _value = value;
      };
    }
  }


  public void Run() {
    while (true) {
      int mult = _rnd.Next(-1, +2);
      if (mult != 0)
        Value += _rnd.NextDouble() * mult;
      Thread.Sleep(1000);
    }
  }
}