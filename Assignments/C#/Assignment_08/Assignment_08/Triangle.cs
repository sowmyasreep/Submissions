
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace Assignment_08
{
    public class Triangle : IShape
    {
        int a = 8;
        int b = 12;
        int c = 18;
        public string GetShapeType()
        {
            return "Triangle";
        }
        public double GetShapeArea()
        {
            return a * b * c;
        }
        public double GetPerimeter()
        {
            return a * b + b * c + c * a;
        }
    }
}
