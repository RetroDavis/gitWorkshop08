using System;
using System.Collections.Generic;
using System.Text;

namespace gitWorkshop08
{
    class Star
    {
        public static void calculateStar(int star)
        {
            int whole = star * 4;
            double inside = star;
            inside = ((whole/2)*0.3)*2;
            double end = whole - inside;

            Console.WriteLn(end.ToSting());
        }
    }
}
