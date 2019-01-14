using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    /// <summary>
    /// Rectangle class has been created which is inheritance from shape class
    /// paramater take and create shape
    /// </summary>


    class Rectangle : Shape
    {
        int width, height;              //declaring parameter
        int a, b;
        public Rectangle() : base()
        {
            width = 100;                      //default constructror 
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
        /// <summary>
        /// parameterize method has been created
        /// set color in the line usin pen libary 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="store"></param>
        /// <param name="i"></param>
        /// <param name="hash"></param>
        public override void draw(Graphics g,string[] store,int i,Hashtable hash)
        {
            //rectangle 100 100 100 100 repeat 10 + 10
            Pen p = new Pen(Color.Black, 2);
            try
            {
                x = Int32.Parse(hash[store[1]] + "");          //stroing value
            }
            catch (Exception ex)
            {
                x = Int32.Parse(store[1]);                     //stroing value
            }
            try
            {
                y = Int32.Parse(hash[store[2]] + "");                   //stroing value
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

        public  double calcArea(int height,int width)
        {
            return width * height;

        }

        public  double calcPerimeter(int height,int width)
        {
            return (2 * width) + (2 * height);
        }

        public override double calcArea()
        {
            throw new NotImplementedException();
        }

        public override double calcPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}




    



