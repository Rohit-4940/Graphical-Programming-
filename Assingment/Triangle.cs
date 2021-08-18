using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
   class Triangle: Shape
    {
        PointF[] point;

        public Triangle()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">50</param>
        public Triangle(PointF[] point)
        {
            this.point = point;
        }
        public Triangle(Color color, int x, int y, PointF[] point) : base(x, y)
        {
            this.point = point;
        }
         public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c);
            g.DrawPolygon(p, point);
        }
        public override void fill(Graphics g, Color c)
        {
            SolidBrush fill = new SolidBrush(c);
            g.FillPolygon(fill, point);
        }
        public void setPoints(PointF[] point)
        {
            this.point = point;
        }
        public PointF[] getPoint()
        {
            return this.point;
        }
    }
}

