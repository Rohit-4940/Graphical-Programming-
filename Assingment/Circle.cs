using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    public class Circle : Shape
    {
        int radius;

        public Circle() : base()
        {

        }
        public Circle(Color c, int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawEllipse(p, x, y, radius, radius);
        }
        public override void fill(Graphics g, Color c)
        {
            SolidBrush fill = new SolidBrush(c);
            g.FillEllipse(fill, x, y, radius, radius);
        }
        public void setRadius(int radius)
        {
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
        public override void set(Color color, params int[] list)
        {
            base.set(color, list[0], list[1]);
            this.radius = list[2];
        }
    }
}

