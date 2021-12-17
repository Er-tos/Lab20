using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину радиуса.");
            double radius = Convert.ToDouble(Console.ReadLine());
            MyDelegete myDelegete = CalcCircleLength;
            myDelegete += CalcCircleArea;
            myDelegete += CalcSphereVolume;
            myDelegete.Invoke(radius);
            Console.ReadKey();
        }
        delegate double MyDelegete(double R);
        public static double CalcCircleLength(double R)
        {
            double result = 2 * R * Math.PI;
            Console.WriteLine("Площадь круга = {0}", result);
            return result;
        }
        public static double CalcCircleArea(double R)
        {
            double result = R * R* Math.PI;
            Console.WriteLine("Длина окружности = {0}", result);
            return result;
        }
        public static double CalcSphereVolume(double R)
        {
            double result = 4 * R * R * R * Math.PI / 3;
            Console.Write("Объём сферы = {0}", result);
            return result;
        }
    }
}
