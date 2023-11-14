

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Assignment_08
{
    public class Rectangle : IShape
    {
        int length = 15;
        int breadth = 30;
        int height = 10;
        public string GetShapeType()
        {
            return "Rectangle";
        }

        public double GetShapeArea()
        {
            return length * breadth * height;
        }
        public double GetPerimeter()
        {
            return 2 * (length + breadth);
        }
    }

}
