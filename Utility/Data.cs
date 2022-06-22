using System;

namespace VirtualMouse.Utility
{
    public class Data
    {
        // Click Quantity
        public int  QUANTITY_value    = 0;
        public bool QUANTITY_infinity = false;
        public int  QUANTITY_cnt      = 0;

        // Interval beetwen two click
        public int  INTERVAL_value = 0;
        public int  INTERVAL_type  = 0;

        // Click type
        public int  TYPE_value = 0;
        public bool TYPE_doubleclick = false;
    }
}

