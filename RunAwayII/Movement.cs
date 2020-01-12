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

        public int max = 60;
        public int min = 1;

        public int y1 = 12;
        public int spd1 = 1;
        public int Spd_1
        {
            get
            {
                if (y1 < 14)
                {
                    spd1 = rnd.Next(min, max);
                }
 
                return spd1;
            }
        }
        public int y2 = 12;
        public int spd2 = 1;
        public int Spd_2
        {
            get
            {
                if (y2 < 14)
                {
                    spd2 = rnd.Next(min, max);
                }
                return spd2;
            }
        }
        public int y3 = 12;
        public int spd3 = 1;
        public int Spd_3
        {
            get
            {
                if (y3 < 14)
                {
                    spd3 = rnd.Next(min, max);
                }
                return spd3;
            }
        }
        public int y4 = 12;
        public int spd4 = 1;
        public int Spd_4
        {
            get
            {
                if (y4 < 14)
                {
                    spd4 = rnd.Next(min, max);
                }
                return spd4;
            }
        }
        public int y5 = 12;
        public int spd5 = 1;
        public int Spd_5
        {
            get
            {
                if (y5 < 14)
                {
                    spd5 = rnd.Next(min, max);
                }
                return spd5;
            }
        }
        public int y6 = 12;
        public int spd6 = 1;
        public int Spd_6
        {
            get
            {
                if (y6 < 14)
                {
                    spd6 = rnd.Next(min, max);
                }
                return spd6;
            }
        }
        public int y7 = 12;
        public int spd7 = 1;
        public int Spd_7
        {
            get
            {
                if (y7 < 14)
                {
                    spd7 = rnd.Next(min, max);
                }
                return spd7;
            }
        }
        public int y8 = 12;
        public int spd8 = 1;
        public int Spd_8
        {
            get
            {
                if (y8 < 14)
                {
                    spd8 = rnd.Next(min, max);
                }
                return spd8;
            }
        }
        public int y9 = 12;
        public int spd9 = 1;
        public int Spd_9
        {
            get
            {
                if (y9 < 14)
                {
                    spd9 = rnd.Next(min, max);
                }
                return spd9;
            }
        }
    }
}