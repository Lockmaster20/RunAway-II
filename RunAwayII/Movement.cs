using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAwayII
{
    class Movement
    {
        //144
        private double mexe;

        public string input
        {
            set
            {
                mexe = Convert.ToDouble(value) * Convert.ToDouble(value);
            }
        }

        public string velocidade
        {
            get
            {
                return mexe.ToString();
            }
        }

    }
}
