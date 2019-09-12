using System;
using System.Linq;

namespace TriangleSort
{
    public class Triangle : IFigure
    {
        #region Properties

        public string Name { get; private set; }

        private double[] _sides = new double[3];
        
        public double Area
        {
            get
            {
                double halfPerimeter = _sides.Sum() / 2.0;

                double tmp = 1;
                foreach (var side in _sides)
                {
                    tmp *= halfPerimeter - side;
                }

                return Math.Sqrt(halfPerimeter * tmp);
            }
        }

        #endregion

        #region Ctor

        public Triangle(string name, double firstSide, double secondSide, double thirddSide)
        {
            Name = name;
            _sides[0] = firstSide;
            _sides[1] = secondSide;
            _sides[2] = thirddSide;

        }

        #endregion

        public static bool IsTriangleExist(double firstSide, double secondSide, double thirddSide)
        {
            return (firstSide + secondSide > thirddSide && 
                firstSide + thirddSide > secondSide && secondSide + thirddSide > firstSide);
        }

        public override string ToString()
        {
            return string.Format($"[{Name}]: {Area} cm");
        }
   

    }
}
