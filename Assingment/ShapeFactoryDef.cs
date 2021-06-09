using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    class ShapeFactoryDef
    {
        public bool isCircle(string shape)
        {
            if (shape == "circle")
            {
                return true;
            }
            return false;
        }
        public bool isRectangle(string shape)
        {
            if (shape == "rectangle")
            {
                return true;
            }
            return false;
        }
        public bool isTriangle(string shape)
        {
            if (shape == "triangle")
            {
                return true;
            }
            return false;
        }
    }
}

