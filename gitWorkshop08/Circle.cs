using System;
using System.Collections.Generic;
using System.Text;

namespace gitWorkshop08
{
    class Circle
    {
        public static void circle()
        {
            double radius;
            Console.WriteLine("Enter radius of circle");
            radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * (radius * radius);
            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}
