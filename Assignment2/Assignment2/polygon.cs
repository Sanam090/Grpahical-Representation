using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class polygon : Shape
    {
        public override double calcArea()
        {
            throw new NotImplementedException();
        }

        public override double calcPerimeter()
        {
            throw new NotImplementedException();
        }

        public override void draw(Graphics g, string[] store,int i,Hashtable hash)
        {
            Pen p = new Pen(Color.Black, 2);
            Point[] po = new Point[5];
            try
            {
                po[0] = new Point(Int32.Parse(hash[store[1]] + ""), Int32.Parse(hash[store[2]] + ""));
            }
            catch (Exception ex)
            {
                po[0] = new Point(Int32.Parse(store[1]), Int32.Parse(store[2]));

            }
            try
            {
                po[1] = new Point(Int32.Parse(hash[store[3]] + ""), Int32.Parse(hash[store[4]] + ""));
            }
            catch (Exception ex)
            {
                po[1] = new Point(Int32.Parse(store[3]), Int32.Parse(store[4]));

            }
            try
            {
                po[2] = new Point(Int32.Parse(hash[store[5]] + ""), Int32.Parse(hash[store[6]] + ""));
            }
            catch (Exception ex)
            {
                po[2] = new Point(Int32.Parse(store[5]), Int32.Parse(store[6]));

            }
            try
            {
                po[3] = new Point(Int32.Parse(hash[store[7]] + ""), Int32.Parse(hash[store[8]] + ""));
            }
            catch (Exception ex)
            {
                po[3] = new Point(Int32.Parse(store[7]), Int32.Parse(store[8]));

            }
           
            if (store.Length == 9)
            {
                g.DrawPolygon(p, po);
            }
            else if (store.Length==13)
            {
                //polygon 100 100 150 200 50 75 100 250 repeat 10 - 10
                int dec = 0;
                if (store[11] == "+")
                {
                    for (int j = 0; j < Int32.Parse(store[8]); j++)
                    {
                        Point[] pop = new Point[5];
                        pop[0] = new Point(Int32.Parse(store[1])+dec, Int32.Parse(store[2])+dec);
                        pop[1] = new Point(Int32.Parse(store[3])+dec, Int32.Parse(store[4])+dec);
                        pop[2] = new Point(Int32.Parse(store[5])+dec, Int32.Parse(store[6])+dec);
                        pop[3] = new Point(Int32.Parse(store[7]+dec), Int32.Parse(store[8])+dec);
                        g.DrawPolygon(p, pop);
                        dec = dec + Int32.Parse(store[10]);
                    }
                }
                else if (store[11] == "-")
                {
                    for (int j = 0; j < Int32.Parse(store[6]); j++)
                    {
                        Point[] pop1 = new Point[5];
                        pop1[0] = new Point(Int32.Parse(store[1]) + dec, Int32.Parse(store[2]) + dec);
                        pop1[1] = new Point(Int32.Parse(store[3]) + dec, Int32.Parse(store[4]) + dec);
                        pop1[2] = new Point(Int32.Parse(store[5]) + dec, Int32.Parse(store[6]) + dec);
                        pop1[3] = new Point(Int32.Parse(store[7] + dec), Int32.Parse(store[8]) + dec);
                        g.DrawPolygon(p, pop1);
                        dec = dec - Int32.Parse(store[10]);
                    }

                }

            }
            else
            {

            }
        }
    }
}
