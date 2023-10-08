using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Triangle:IShape
    {
        int breadth = 5;
        int height = 6;
        int a = 4, b = 6, c = 7;
        public double GetCircumference()
        {
            return a + b + c;
        }

        public double  GetArea()
        {
            return (0.5)*breadth*height ;
        }

        public string ShapeType()
        {
            return "Triangle";
        }
    }
}
    

