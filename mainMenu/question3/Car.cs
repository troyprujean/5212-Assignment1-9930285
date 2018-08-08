using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    public class Car
    {
        string colour, make, gearbox;

        public string GetColour()
        {
            return colour;
        }

        void SetColour(string col)
        {
            colour = col;
        }

        public string GetMake()
        {
            return make;
        }

        void SetMake(string mk)
        {
            make = mk;
        }

        public string GetGearbox()
        {
            return gearbox;
        }

        void SetGearbox(string gbox)
        {
            gearbox = gbox;
        }

        public Car (string _colour, string _make, string _gearbox)
        {
            SetColour(_colour);
            SetMake(_make);
            SetGearbox(_gearbox);
        }
    }
}
