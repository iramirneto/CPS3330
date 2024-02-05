//Iramir Neto
//CPS3330*01
//Lab #2

using System;

namespace Average
{
    public class NumAve
    {
        public static double MyAve(double num1, double num2)
        {
            double ave;
            ave = (num1 + num2) / 2;

            Console.WriteLine("The average of " + num1 + " and " + num2 +
                " is " + ave);
            return ave;
        }

        public static double MyAve(double num1, double num2, double num3)
        {
            double ave;
            ave = (num1 + num2 + num3) / 3;

            Console.WriteLine("The average of " + num1 + ", " + num2 +
                " and " + num3 + " is " + ave);
            return ave;
        }
    }
} 