//Author: Troy Prujean
//Date: 14/08/2018
//Title: 5212 - Assignment 1 - Question 1 - Car class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    public class Car
    {
        string colour, make, gearbox;

        public string GetColour()
        {
            return colour;
        }

        public void SetColour(string col)
        {
            colour = col;
        }

        public string GetMake ()
        {
            return make;
        }

        public void SetMake (string mk)
        {
            make = mk;
        }

        public string GetGearbox()
        {
            return gearbox;
        }

        public void SetGearbox(string gbox)
        {
            gearbox = gbox;
        }
    }
}
