using System;
using System.Linq;

namespace TriangleSort
{
    public class Triangle: IFigure
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

        public Triangle(string name, double[] sides)
        {
            Name = name;
            Sides = sides;
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
