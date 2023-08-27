using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1Square_found
{
    public class Library
    {
        static public void Stop(string str2)
        {
            Console.WriteLine(str2);
            Console.ReadKey();
        }
        
        
        static public void Pause(string str)
        {
            Console.WriteLine(str);
            
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Вы вводите  радиус окружности: ");
                double b = Convert.ToDouble(Console.ReadLine());
                
                if (b <= 0)
                {
                    throw new ArgumentException("Радиус не может быть отрицательным или меньше нуля");
                }
                double S = Math.PI * Math.Pow(b, 2);
                Console.Write("площадь окружности равна: ");
                Console.WriteLine(S);
                
                
            }
            if (a == 2)
            {
                Console.WriteLine("Вы вводите длину прямоугольника: ");
                double c = Convert.ToDouble(Console.ReadLine());
                if (c <= 0)
                {
                    throw new ArgumentException("Длина должна быть положительной");
                }
                Console.WriteLine("Вы вводите ширину прямоугольника: ");
                double d = Convert.ToDouble(Console.ReadLine());
                if (d <= 0)
                {
                    throw new ArgumentException("Ширина должна быть положительной");
                }
                double S = c * d;
                Console.Write("Площадь прямоугольнка равна: ");
                Console.WriteLine(S);
               
            }
            if (a == 3)
            {
                Console.WriteLine("Вы вводите длины сторон треугольника, длина первой стороны: ");
                double t1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вы вводите длину второй стороны треугольника: ");
                double t2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вы вводите длину третьей стороны треугольника: ");
                double t3 = Convert.ToDouble(Console.ReadLine());
                if (t1 <=0 || t2 <=0 || t3 <= 0)
                {
                    throw new ArgumentException("Сторона должна быть положительной длины");
                }
                // Проверка являются ли заданные стороны сторонами треугольника:
                if ((t1 + t2) > t3 && (t2 + t3) > t1 && (t1 + t3) > t2)
                {
                    Console.WriteLine("Это треугольник");
                }
                else
                {
                    throw new ArgumentException("Это не треугольник");
                }

                double p = (t1 + t2 + t3) / 2; // узнаем полупериметр треугольника
                double S = Math.Sqrt(p * (p - t1) * (p - t2) * (p - t3));

                Console.Write("Площадь треугольника равна: ");
                Console.WriteLine(S);
                
                if (
                    (t1 * t1 + t2 * t2 == t3 * t3)
                    || (t1 * t1 + t3 * t3 == t2 * t2)
                    || (t3 * t3 + t2 * t2 == t1 * t1)
                )
                {
                    Console.WriteLine("Треугольник является прямоугольным");
                }
                else
                {
                    Console.WriteLine("Треугольник не является прямоугольным");
                }
                
            }
            if (a > 3)
            {
                Console.WriteLine("Добавление новой фигуры");
                
            }
            
        }
        static public double Rad(double b)
        {
            double S = Math.PI * Math.Pow(b, 2);
            return S;

        }
        static public double Square(double c,double d)
        {
            double S = c * d;
            return S;
        }
        static public double Triangle(double t1, double t2, double t3)
        {
            double p = (t1 + t2 + t3) / 2; 
            double S = Math.Sqrt(p * (p - t1) * (p - t2) * (p - t3));
            return S;
        }

    }
}

