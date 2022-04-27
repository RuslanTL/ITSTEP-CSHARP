using System;
using static System.Console;
using System.Diagnostics;

/*
ДОПОЛНИТЕЛЬНО

Problem 03
В проекте Bechmark_InterfaceVsVirtual реализуйте невиртуальный метод HelloNonVirt (полностью аналогичный виртуальному HelloVirt) и проведите измерения времени работы вариантов:
- вызов невиртуальной функции
- вызов виртуальной функции
- вызов функции у интерфейсной переменной

для двух вариантов окружения:
 - Release, x64
 - Debug, x64 
Заполните полученными данными предоставленную таблицу Excel results.xls*/


interface IMovable {
  void Hello();
}

class ClassWithInterface : IMovable {
  public long Count = 0;
  public void Hello() {
    Count++;
  }
}


class Animal {
  public long Count = 0;
  public virtual void HelloVirt() {

  }
  public void HelloNonVirt() {
    Count++;
  }
}


class Bear : Animal {
  public override void HelloVirt() {
    Count++;
  }
}



class Program {
  static void Main() {
    Console.WriteLine("Start");
    long nTimes = 10_000_000;
    Animal animal;
    animal = new Animal();

    var sw = new Stopwatch();
    sw.Start();
    // измерение времени работы невиртуального метода
    //. . .
    //. . .
    for (long i = 0; i < nTimes; i++) {
      animal.HelloNonVirt();
    }
    sw.Stop();
    WriteLine(animal.Count);
    WriteLine($"animal.HelloNonVirt() time : {sw.Elapsed}\n");

    animal = new Bear();
    sw.Restart();
    for (long i = 0; i < nTimes; i++) {
      animal.HelloVirt();
    }
    sw.Stop();
    WriteLine(animal.Count);
    WriteLine($"animal.HelloVirt() time : {sw.Elapsed}\n");


    IMovable interf = new ClassWithInterface();
    sw.Restart();
    for (long i = 0; i < nTimes; i++) {
      interf.Hello();
    }
    sw.Stop();
    WriteLine(((ClassWithInterface)interf).Count);
    WriteLine($"interf.Hello() time     : {sw.Elapsed}\n");

    WriteLine("\nEnd . . .");
    ReadLine();
  }
}