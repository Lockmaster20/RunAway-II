using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAwayII
{
    class Movement
    {
        //private Random rnd = new Random();

        //public int recebe;

        RunAwayII.Form1 formed;
        string why;

        public Movement(Form1 formed)
        {
            this.formed = formed;
        }

        public void testexmaple()
        {
            why = "2";

            formed.test(why);
        }
    }
}

