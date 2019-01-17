using System;
using System.Collections.Generic;
using System.Text;

namespace gitWorkshop08
{
    class Rectangle
    {
        public static void Rectanglearea() {
            double l = Convert.ToDouble(Console.ReadLine());
            double w = Convert.ToDouble(Console.ReadLine());
            double area = l * w;
            Console.WriteLine(area);
        }
    }
}
