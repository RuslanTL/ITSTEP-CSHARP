global using static System.Console;
namespace DemoNS;
class Program {

  static void Main(string[] args) {
    try {
      //BasicDemo.Demo();
      //RealDemo.Demo();
      //LambdaDemo.Demo();
      //InstanceMethodsDemo.Demo();
      //InterfaceInsteadOfDelegateDemo.Demo();
      MulticastDemo.Demo();

      //ContrvarianceDemo.Demo(); //dont!
    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    ReadLine();
  }
}