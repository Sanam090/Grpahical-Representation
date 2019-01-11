﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ShapeFactory
    {
        public Shape getShape(String shapeType)
        {
            shapeType = shapeType.ToUpper().Trim(); //you could argue that you want a specific word string to create an object but I'm allowing any case combination


            if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else
            {
                //if we get here then what has been passed in is unknown so throw an appropriate exception
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }


        }
    }


}

