using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class triangle:Shape
    {
        public override double calcArea()
        {
            throw new NotImplementedException();
        }

        public override double calcPerimeter()
        {
            throw new NotImplementedException();
        }

        public override void draw(Graphics g,int[] store)
        {
            Pen p = new Pen(Color.Black, 2);
            x = store[0];
            y = store[1];
            
        }

     
    }
}
