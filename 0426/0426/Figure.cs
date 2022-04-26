using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 03 - Figures
Создайте абстрактный базовый класс Figure с абстрактными методами вычисления площади и периметра. Создайте производные классы: Rectangle (прямоугольник), Circle (круг), Trapezium (трапеция) со своими функциями площади и периметра. 
В конструкторе трапеции задавайте длины 4-н сторон, для определения площади найдите в справочниках довольно длинную формулу!  

В static class FigureDemo напишите методы:
public static double GetArea(List<Figure> figures) - общая площадь
public static double GetPerimeter(List<Figure> figures) - общий периметр
public static (double min, double max, double avr) GetAreaStats(List<Figure> figures) - макcимальное, минимальное и среднее значения площади
public static (double min, double max, double avr) GetPerimeterStats(List<Figure> figures) - то же с периметром
public static Figure FindFigureWithMaxArea(List<Figure> figures) - фигура с наибольшей площадью 
public static Figure FindFigureWithMaxPerimeter(List<Figure> figures) - фигура с наибольшим периметром 

public static SortByArea (List<Figure> figures)
public static SortByPerimeter (List<Figure> figures)

Создайте List<Figure> figures, содержащий фигуры разных типов.
Продемонстрируйте работу всех методов.*/
namespace _0426 {
  public abstract class Figure {
    public static double GetArea(List<Figure> figures) {

    
    }


    public static double GetPerimeter(List<Figure> figures) {

    }
    

    public static (double min, double max, double avr) GetAreaStats(List<Figure> figures) { 
    
    } 
    public static (double min, double max, double avr) GetPerimeterStats(List<Figure> figures) {

    }


    public static Figure FindFigureWithMaxArea(List<Figure> figures) {


    }


    public static Figure FindFigureWithMaxPerimeter(List<Figure> figures) {


    }

    public static void SortByArea(List<Figure> figures) {

    }
    public static void SortByPerimeter(List<Figure> figures) {

    }

  }

  public class Rectangle : Figure {
    int a, b;
    public Rectangle() {
      var rnd = new Random();
      a = rnd.Next(1, 50);
      b = rnd.Next(1, 50);
    }


  }
  public class Circle : Figure {
    int radius;

    public Circle() {
      var rnd = new Random();
      radius = rnd.Next(1, 50);
    }
  }
  public class Trapezium : Figure {
    int a, b, c, d;

    public Trapezium() {
      var rnd = new Random();
      
    }

  }
}
