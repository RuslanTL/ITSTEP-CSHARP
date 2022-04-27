using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0427 {
  public static class IRunnableDemo {
    public static void Run(List<IRunnable> runnables, double speed) {
      Console.WriteLine($"trying to run vehicles at speed: {speed}..");
      foreach(IRunnable runnable in runnables) {
        runnable.Run(speed);
      }
      
    }
    public static double GetAverageSpeed(List<IRunnable> runnables) {
      double speedSum = 0;
      foreach(IRunnable runnable in runnables) {
        speedSum += runnable.Speed;
      }
      return speedSum / runnables.Count();

    }
  }
}
