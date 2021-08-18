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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="x">20</param>
        /// <param name="y">10</param>
        /// <param name="radius">30</param>
        public Circle(Color c, int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="c"></param>
        /// <param name="thickness"></param>
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawEllipse(p, x, y, radius, radius);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g">4</param>
        /// <param name="c">4</param>
        public override void fill(Graphics g, Color c)
        {
            SolidBrush fill = new SolidBrush(c);
            g.FillEllipse(fill, x, y, radius, radius);
        }
        public void setRadius(int radius)
        {
            this.radius = radius;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getRadius()
        {
            return radius;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color">red</param>
        /// <param name="list">xyz</param>
        public override void set(Color color, params int[] list)
        {
            base.set(color, list[0], list[1]);
            this.radius = list[2];
        }
    }
}

