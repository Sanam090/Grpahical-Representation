using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class circle : Shape
    {
        String hashvalue;
        int x;
        int y;
        int z;
        public override double calcArea()
        {
            throw new NotImplementedException();
        }

        public override double calcPerimeter()
        {
            throw new NotImplementedException();
        }

        public override void draw(Graphics g,string[] store,int i)
        {
            Pen p = new Pen(Color.Black, 2);
            x = Int32.Parse(store[1]);
            y = Int32.Parse(store[2]);
            int a = Int32.Parse(store[3]);
            int b = Int32.Parse(store[4]);

            if (store.Length == 5)
            {
                g.DrawEllipse(p, x, y, a, b);
            }
            else if (store.Length == 9)
            {
                int dec = 0;
                //circle 100 100 100 100 repeat 10 + 10
                if (store[7] == "+")
                {
                    for (int j = 0; j < Int32.Parse(store[6]); j++)
                    {
                        g.DrawEllipse(p, x, y, a + dec, b + dec);
                        dec = dec + Int32.Parse(store[8]);
                    }
                }
                else if (store[7] == "-")
                {
                    for (int j = 0; j < Int32.Parse(store[6]); j++)
                    {
                        g.DrawEllipse(p, x, y, a + dec, b + dec);
                        dec = dec - Int32.Parse(store[8]);
                    }
                }
            
            else
            {

            }
                //int pFrom = store[i].IndexOf("if") + "if".Length;
                //int pTo = store[i].LastIndexOf("==");

                //hashvalue =store[i].Substring(pFrom, pTo - pFrom);

                //int pFrom1 = store[i].IndexOf("if") + "if".Length;
                //int pTo1 = store[i].LastIndexOf("==");

                //hashvalue = store[i].Substring(pFrom, pTo - pFrom);
                
            }
        }
    }
}
