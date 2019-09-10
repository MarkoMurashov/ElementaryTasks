using System;

namespace TriangleSort
{
    public class TriangleFactory : IFigureFactory
    {
        #region Properties

        public string Name { get; private set; }

        public double[] Sides { get; private set; }

        #endregion

        #region Ctor

        public TriangleFactory(string name, double[] sides)
        {
            Name = name;
            Sides = sides;
        }

        #endregion

        public IFigure Create()
        {
            if (Sides == null)
            {
                throw new InvalidCastException();
            }

            return new Triangle(Name, Sides);
        }

        bool IFigureFactory.Equals(object obj)
        {
            if (obj is TriangleFactory factory)
            {
                bool equal = true;
                for (int i = 0; i < Sides.Length; i++)
                {
                    if (Sides[i] != factory.Sides[i])
                    {
                        equal = false;
                        break;
                    }
                }

                return Name == factory.Name && equal;
            }
            throw new InvalidCastException();
        }
    }
}
