using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// Rectangle class has been created which is inheritance from shape class
    /// paramater take and create shape
    /// The Hashtable class represents a collection of key-and-value pairs that 
    ///  are organized based on the hash code of the key.
    /// </summary>
    class circle : Shape
    {
        String hashvalue;
        int x;
        int y;
        int a;
        int b;
        public override double calcArea()
        {
            throw new NotImplementedException();
        }

        public override double calcPerimeter()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// The Hashtable class represents a collection of key-and-value pairs that 
        ///  are organized based on the hash code of the key.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="store"></param>
        /// <param name="i"></param>
        /// <param name="hash"></param>

        public override void draw(Graphics g,string[] store,int i,Hashtable hash)
        {
            Pen p = new Pen(Color.Black, 2);
            try
            {
                x = Int32.Parse(hash[store[1]]+"");             //storing value
            }
            catch (Exception ex)
            {
                x = Int32.Parse(store[1]);
            }
            try
            {
                y = Int32.Parse(hash[store[2]] + "");
            }
            catch (Exception ex)
            {
                y = Int32.Parse(store[2]);
            }
            try
            {
                a = Int32.Parse(hash[store[3]] + "");
            }
            catch (Exception ex)
            {
                a = Int32.Parse(store[3]);
            }
            try
            {
                b = Int32.Parse(hash[store[4]] + "");
            }
            catch (Exception ex)
            {
                b = Int32.Parse(store[4]);
            }
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
