﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    interface shapes
    {
        void set(Color c, params int[] list);
        void draw(Graphics g,int[] store);
        double calcArea();
        double calcPerimeter();





    }
}
