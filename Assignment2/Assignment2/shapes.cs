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
    /// shapes interface is created
    /// diferent method has been called in this interface
    /// </summary>
    interface shapes
    {
        void set(Color c, params int[] list);
        void draw(Graphics g,string[] store,int i,Hashtable hash);
        double calcArea();
        double calcPerimeter();
    }
}
