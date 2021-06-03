using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
  public  interface Ifactory
    {

        void draw(Graphics g, Color c, int thickness);
        void fill(Graphics g, Color c);
    }
}
