using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{
    public class message
    {
        public string pseudo;
        public string msg;
        public DateTime date;

        public message(string p, string m, DateTime d)
        {
            pseudo = p;
            msg = m;
            date = d;
        }
    }
}
