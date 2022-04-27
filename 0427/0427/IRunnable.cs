using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 01 (IRunnable) - реализации задачи Vehicles с помощью интерфейса.
В отдельном файле IRunnable.cs создайте интерфейс
interface IRunnable {
	double MaxSpeed { get; set; }
	double Speed { get; set; }
	void Run(double speed);
}
*/
namespace _0427 {
	public interface IRunnable {
		double MaxSpeed { get; set; }
		double Speed { get; set; }
		void Run(double speed);
	}
}
