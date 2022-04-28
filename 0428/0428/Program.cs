/*Problem 01
Приведите собственные примеры использования следующих Func and Action delegates (аналогично демонстрациям BasicDemo и LambdaDemo):
delegate TResult Func<TResult>();
delegate TResult Func<T, TResult>(T arg);
delegate TResult Func<T1, T2, TResult> (T1 arg1, T2 arg2);
delegate void Action();
delegate void Action<T>(T arg);
delegate void Action<T1, T2>(T1 arg1, T2 arg2);
			

		
Problem 02
Напишите методы поэлементного преобразования массива и List с помощью f:
static void Transform(double[] arr, Func<double, double> f) 
static void Transform(List<double> list, Func<double, double> f) 

Создайте исходные массив и List. Вызывайте данные методы для КОПИЙ массива и List c различными встроенными и своими (используя ламбда-выражения) функциями (Math.Abs, Sin, Cos, Exp, Log10, . . .).
Результаты выводите с помощью Utils.PrintArray и Utils.PrintList.



Problem 03 (PrintTable)
Напишите методы для вывода на консоль и в файл таблицу аргументов и значений переданной функции
static void PrintTable (List<double> args, Func<double, double> f, string columnName, string fileName = null)

Например: 
PrintTable(xList, (double x) => { return x * x; }, "x*x");
|    x    |     x*x     |
-------------------------
|  0,0000 |      0,0000 |
|  0,5000 |      0,2500 |
|  1,0000 |      1,0000 |
|  1,5000 |      2,2500 |
|  2,0000 |      4,0000 |
|  2,5000 |      6,2500 |
|  3,0000 |      9,0000 |
. . . . . . . . . . . . . . 
 		
Обеспечьте типографическое качество разметки!



Problem 04
Напишите метод
static double[,] CombineMatrices (double[,] mat1, double[,] mat2, Func<double, double, double> f)
производящий поэлементное вычисление mat[i, j] = f(mat1[i, j], mat2[i, j] и возвращающий итоговую матрицу. Обеспечьте проверку mat1 и mat2 на идентичность размеров.
Продемонстрируйте работу для нескольких функций f.



Problem 05
Напишите программу вычисления интеграла от произвольной функции, используя простейший метод суммирования прощади прямоугольников под графиком функции:
static double Integral(double a, double b, int n, Func<double, double> f),
где a, b -пределы интегрирования, n = количесто интервалов разбиения, f - интегрируемая функция.

Вычислите интегралы для различных встроенных и своих (дополнительно) функций. Рассмотрите не менее 3-х вариантов функций.
Сделайте расчеты с различными n.
Сравните результаты с точными значениями интегралов, используя известные формулы.
Например, действуя по образцу:
public static void Demo() {
	double a = 1;
	double b = 10;
	Func<double, double> f = (double x) => x * x;
	double exactResult = b*b*b/3 - a*a*a/3;
	long n = 10;
	for (int i = 0; i < 10; i++) {
		double res = Integral(a, b, n, f);
		WriteLine($"i = {i,2} n = {n,12}  {res,18:N10}  {exactResult,6:N2}  diff = {res - exactResult :0.00000000}");
		n *= 10;
	}
}





*/

global using System;

namespace _0428;
class Program {


	static void Main(string[] args) {
		//Problem1.Demo();
		//Problem2.Demo();
		Problem3.Demo();
  }
}


