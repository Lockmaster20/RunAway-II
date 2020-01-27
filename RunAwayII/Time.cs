using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAwayII
{
    class Time
    {
        public bool t1 = false;
        public bool t2 = false;
        public bool t3 = false;
        public bool t4 = false;
        public bool t5 = false;
        public bool t6 = false;
        public bool t7 = false;
        public bool t8 = false;
        public bool t9 = false;

        public void start()
        {
            t1 = true;
            t2 = true;
            t3 = true;
            t4 = true;
            t5 = true;
            t6 = true;
            t7 = true;
            t8 = true;
            t9 = true;
        }

        public void stop()
        {
            t1 = false;
            t2 = false;
            t3 = false;
            t4 = false;
            t5 = false;
            t6 = false;
            t7 = false;
            t8 = false;
            t9 = false;
        }

        public void pausing()
        {
            if (t1 == true)  t1 = false; else t1 = true;
            if (t2 == true) t2 = false; else t2 = true;
            if (t3 == true) t3 = false; else t3 = true;
            if (t4 == true) t4 = false; else t4 = true;
            if (t5 == true) t5 = false; else t5 = true;
            if (t6 == true) t6 = false; else t6 = true;
            if (t7 == true) t7 = false; else t7 = true;
            if (t8 == true) t8 = false; else t8 = true;
            if (t9 == true) t9 = false; else t9 = true;
        }
    }
}
