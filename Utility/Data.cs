using System;

namespace VirtualMouse.Utility
{
    public class Data
    {

        // Interval beetwen two click
        public int INTERVAL_value = 0;
        public int INTERVAL_type = 0;
        public int INTERVAL_TYPE_FIXED = 1;
        public int INTERVAL_TYPE_RANDOM = 2;

        // Click Repeat
        public int  REPEAT_value    = 0;
        public bool REPEAT_infinity = false;
        public int  REPEAT_cnt = 0;

        // Click Options
        public int  TYPE_value = 0;
        public bool TYPE_doubleclick = false;
    }
}

