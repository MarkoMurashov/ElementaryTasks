using System;

namespace TriangleSort
{
    class Triangle
    {
        public string Name { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double Square
        {
            get
            {
                double p = ((Side1 + Side2 + Side3) / 2.0);
                return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            }
        }

        public Triangle(string name, double side1, double side2, double side3)
        {
            Name = name;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override string ToString()
        {
            return string.Format($"[{Name}]: {Square} cm");
        }
    }
}
