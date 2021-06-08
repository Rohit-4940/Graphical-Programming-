using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment
{
    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            shapeType = shapeType.ToLower().Trim();

            if (shapeType == null)
            {
                return null;
            }
            else if (shapeType.Equals("circle"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle();
            }
            else
            {
                MessageBox.Show("Factory error: " + shapeType + " does not exist");
                return null;
            }

        }
    }
}

