using System;
using System.Collections.Generic;
using System.Text;

namespace gitWorkshop08
{
    class Rombus
    {




        public static void robusArea(int pHight, int qLength)
        {

            if (pHight > 0 && qLength > 0)
            {
                Console.WriteLine((pHight * qLength) / 2);
            }
            else
            {
                Console.WriteLine("Both the q and p are supposed to be >0");   
            }


        }



    }
}
