
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Assignment_08
{
    public class ShapeFactory
    {
        public static IShape GetShapes(string ShapeType)
        {
            IShape Iss = null;
            if (ShapeType == "Square")
            {
                Iss = new Square();
            }
            else if (ShapeType == "Rectangle")
            {
                Iss = new Rectangle();
            }
            else if (ShapeType == "Triangle")
            {
                Iss = new Triangle();
            }
            return Iss;
        }
    }
}
