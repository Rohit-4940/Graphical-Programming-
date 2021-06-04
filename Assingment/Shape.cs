using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    public abstract class Shape : Ifactory
    {
        protected int x = 0, y = 0, z = 0;
        protected Color color;

        public Shape()
        {

        }
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Shape(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public virtual void set(Color color, params int[] list)
        {
            this.color = color;
            this.x = list[0];
            this.y = list[1];
        }
        public abstract void draw(Graphics g, Color c, int thickness);
        public abstract void fill(Graphics g, Color c);
    }
}
