using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
  [TestFixture]
    
    class unittesting
    {
        Rectangle rg = new Rectangle();
        [TestCase]
        public void test()
        {
            int width = 4;
            int height=3;
            Assert.AreEqual(width * height, rg.calcArea(height,width));

        }
        [TestCase]
        public void test1()
        {
            
        int width = 4;
            int height = 3;
            Assert.AreEqual((2*width)+(2*height), rg.calcPerimeter(height, width));

        }

    }
}
