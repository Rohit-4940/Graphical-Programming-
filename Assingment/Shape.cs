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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">10</param>
        /// <param name="y">10</param>
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">5</param>
        /// <param name="y">10</param>
        /// <param name="z">15</param>
        public Shape(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">5</param>
        public void setX(int x)
        {
            this.x = x;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="y">10</param>
        public void setY(int y)
        {
            this.y = y;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color">green</param>
        /// <param name="list">no of list</param>
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
