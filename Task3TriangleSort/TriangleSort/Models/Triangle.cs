using System;
using System.Linq;

namespace TriangleSort
{
    public class Triangle : IFigure
    {
        #region Properties

        public string Name { get; private set; }
        public double[] Sides { get; private set; }

        public double Square
        {
            get
            {
                double halfPerimeter = Sides.Sum() / 2.0;

                double tmp = 1;
                foreach (var side in Sides)
                {
                    tmp *= halfPerimeter - side;
                }

                return Math.Sqrt(halfPerimeter * tmp);
            }
        }

        #endregion

        #region Ctor

        public Triangle(string name, double[] sides)
        {
            Name = name;
            Sides = sides;
        }

        #endregion

        public static bool IsTriangleExist(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        public override string ToString()
        {
            return string.Format($"[{Name}]: {Square} cm");
        }

        bool IFigure.Equals(object obj)
        {
            if (obj is Triangle triangle)
            {
                bool equal = true;
                for (int i = 0; i < Sides.Length; i++)
                {
                    if (Sides[i] != triangle.Sides[i])
                    {
                        equal = false;
                        break;
                    }
                }

                return Name == triangle.Name && equal;
            }

            throw new InvalidCastException();
        }

    }
}
