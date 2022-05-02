namespace CarDelegate;
public class Car {
  public string Name { get; set; }
  public int MaxSpeed { get; set; } = 100;
  public int Speed { get; set; }

  private bool carIsDead;

  public Car() { }
  public Car(string name, int maxSp, int currSp) {
    Name = name;
    MaxSpeed = maxSp;
    Speed = currSp;
  }



  #region Delegate infrastructure
  public delegate void CarEngineHandler(string msgForCaller);

  private CarEngineHandler listOfHandlers;

  public void RegisterWithCarEngine(CarEngineHandler methodToCall) {
    if (listOfHandlers == null) {
      listOfHandlers = methodToCall;
    } else {
      listOfHandlers += methodToCall;
      //or:
      //listOfHandlers = Delegate.Combine(listOfHandlers, methodToCall) as CarEngineHandler;
    }
  }


  public void UnRegisterWithCarEngine(CarEngineHandler methodToCall) {
    listOfHandlers -= methodToCall;
  }


  public void Accelerate(int delta) {
    if (carIsDead) {
      if (listOfHandlers != null)
        listOfHandlers("Sorry, this car is dead...");
      return;
    }

    Speed += delta;

    if ((MaxSpeed - Speed) <= 15 && listOfHandlers != null) {
      listOfHandlers("Осторожно! Сейчас взорвусь!");
    }

    if (Speed >= MaxSpeed) {
      carIsDead = true;
    } else {
      //Console.WriteLine($"Speed = {Speed}");
      if (listOfHandlers != null)
        listOfHandlers(Speed.ToString());
    }

  }
  #endregion
}

