﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormDelegateApp
{

    internal static class CalculateResult
    {

        public static double pi = 3.1415;

        public delegate double  OperationDelegate(double pi);
        public static double countS(double radius )
        {
            double resultS = pi * Math.Pow(radius, 2);
            return resultS;
        }
        public static double countL(double radius )
        {
            double resultL = (2 * pi * radius);
            return resultL;
        }
        public static double countP(double radius)
        {
            double resultP = 4 * pi * Math.Pow(radius, 2);
            return resultP;
        }
        public static double countV(double radius)
        {
            double resultV = (4 / 3) * pi * Math.Pow(radius, 3);
            return resultV;
        }
        public static double countD(double radius)
        {
            double resultD = (2 * radius);
            return resultD;
        }
        //Dictionary<string, OperationDelegate> operat = new Dictionary<string, OperationDelegate>()
        //{
        //    ["countS"] = (radius, pi) => (pi * Math.Pow(radius, 2)),
        //    ["countL"] = (radius, pi) => (2 * pi * radius),
        //    ["countP"] = (radius, pi) => (4 * pi * Math.Pow(radius, 2)),
        //    ["countV"] = (radius, pi) => ((4 / 3) * pi * Math.Pow(radius, 3)),
        //    ["countD"] = (radius, pi) => (2 * radius),
        //};
    }
}
