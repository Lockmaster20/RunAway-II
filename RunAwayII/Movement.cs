using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAwayII
{
    class Movement
    {
        public Random rnd = new Random();
        public int y1 = 12;
        public int spd1 = 1;

        public int Spd_1
        {
            get
            {
                if (y1 < 500)
                {
                    spd1 = rnd.Next(10, 30);
                }
                return spd1;
            }
        }
    }
}

