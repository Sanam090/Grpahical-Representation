using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{


    class Rectangle : Shape
    {
        int width, height;
        int a, b;
        public Rectangle() : base()
        {
            width = 100;
            height = 100;
        }
        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {

            this.width = width; //the only thing that is different from shape
            this.height = height;
        }

        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0], list[1]);
            this.width = list[2];
            this.height = list[3];

        }

        public override void draw(Graphics g,string[] store,int i)
        {
            //rectangle 100 100 100 100 repeat 10 + 10
            Pen p = new Pen(Color.Black, 2);
            x = Int32.Parse(store[1]);
            y = Int32.Parse(store[2]);
            a= Int32.Parse(store[3]);
            b= Int32.Parse(store[4]);
            if (store.Length == 5)
            {
                g.DrawRectangle(p, x, y, a, b);
            }
            else if (store.Length == 9)
            {
                int dec = 0;
                if (store[7] == "+")
                {
                    for (int j = 0; j < Int32.Parse(store[6]); j++)
                    {
                        g.DrawRectangle(p, x, y, a + dec, b + dec);
                        dec = dec + Int32.Parse(store[8]);
                    }
                }
                else if(store[7]=="-"){
                    for (int j = 0; j < Int32.Parse(store[6]); j++)
                    {
                        g.DrawRectangle(p, x, y, a + dec, b + dec);
                        dec = dec - Int32.Parse(store[8]);
                    }
                }




            }
            else
            {

            }
        }

        public override double calcArea()
        {
            return width * height;

        }

        public override double calcPerimeter()
        {
            return 2 * width + 2 * height;
        }
    }
}




    



