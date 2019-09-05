using System;

using ConsoleArgsValidation;

namespace TriangleSort
{
    class Triangle
    {
        #region Properties

        private string Name { get; set; }
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Side3 { get; set; }
       
        public double Square
        {
            get
            {
                double p = ((Side1 + Side2 + Side3) / 2.0);

                return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            }
        }

#endregion

        private Triangle(string name, double side1, double side2, double side3)
        {
            Name = name;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public static Triangle Create(IValid valid, string args)
        {
            float[] sides = valid.TryTriangleArgsParse(args, out string name);

            return new Triangle(name, sides[0], sides[1], sides[2]);
        }

        public static bool IsTriangleExist(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        public override string ToString()
        {
            return string.Format($"[{Name}]: {Square} cm");
        }
       
    }
}
