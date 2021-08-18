using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    public class Rectangle: Shape
    {
        int height, width;
        public Rectangle()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public Rectangle(Color color, int x, int y, int height, int width) : base(x, y)
        {
            this.height = height;
            this.width = width;
        }
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawRectangle(p, x, y, height, width);
        }
        public override void fill(Graphics g, Color c)
        {
            SolidBrush brush = new SolidBrush(c);
            g.FillRectangle(brush, x, y, height, width);
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public void setWidth(int width)
        {
            this.width = width;
        }
        public int getHeight()
        {
            return height;
        }
        public int getWidth()
        {
            return width;
        }
        public override void set(Color color, params int[] list)
        {
            base.set(color, list[0], list[1]);
            this.height = list[2];
            this.width = list[3];
        }
    }
}
