using System;

using ConsoleArgsValidation;

namespace TriangleSort
{
    class TriangleFactory
    {
        private TriangleFactory()
        {

        }

        public static Triangle Create(IValid valid, string args)
        {
            string[] parametrs = valid.GetValidTriangleArgs(args);
           
            double[] sides = valid.GetDoublesFromConsole(parametrs);
           
            if (!IsTriangleExist(sides[0], sides[1], sides[2]))
            {
                throw new Exception(Settings.NOT_EXIST);
            }

            return new Triangle(parametrs[0], sides[0], sides[1], sides[2]);
        }

        public static bool IsTriangleExist(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }
    }
}
