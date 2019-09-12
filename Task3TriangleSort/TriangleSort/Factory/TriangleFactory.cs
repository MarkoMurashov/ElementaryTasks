using System;

namespace TriangleSort
{
    public class TriangleFactory : IFigureFactory
    {
        #region Properties

        public string Name { get; private set; }

        private double[] _sides = new double[3];

        #endregion

        #region Ctor

        public TriangleFactory(string name, double firstSide, double secondSide, double thirddSide)
        {
            Name = name;
            _sides[0] = firstSide;
            _sides[1] = secondSide;
            _sides[2] = thirddSide;
        }

        #endregion

        public IFigure Create()
        {
            return new Triangle(Name, _sides[0], _sides[1], _sides[2]);
        }
     
    }
}
