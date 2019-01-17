using System;
using System.Collections.Generic;
using System.Text;

namespace gitWorkshop08 {
    class Triangle{
        public static void CalculateArea() {
            Console.WriteLine("Enter breadth");
            int breadth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = Int32.Parse(Console.ReadLine());

            if (breadth > 0 && height > 0) {
                int area = (breadth / 2) * height;
                Console.WriteLine(area);
            }

        }

    }
}
