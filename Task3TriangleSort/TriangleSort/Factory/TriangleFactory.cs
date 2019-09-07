using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSort
{
    public class TriangleFactory: IFigureFactory
    {
        public string  Name {  get; private set; }

        public double[] Sides { get; private set; }

        public TriangleFactory(string name, double[] sides)
        {
            Name = name;
            Sides = sides;
        }

        public IFigure Create()
        {
           return new Triangle(Name, Sides);
        }

        bool IFigureFactory.Equals(object obj)
        {
            if(obj is TriangleFactory factory)
            {
                bool equal = true;
                for (int i = 0; i < Sides.Length; i++)
                {
                  if(Sides[i] != factory.Sides[i])
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
