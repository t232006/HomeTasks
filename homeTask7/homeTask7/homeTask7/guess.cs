using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeTask7
{
    class guess
    {
        public guess()
        {
            Random Goal = new Random();
            goal = (byte)Goal.Next(100);
        }
        //string result;
        byte assump;
        public byte Assump
        {
            get { return assump;}
            set { if ((value <= max) && (value >= min))
                    assump = value; }
        }
        byte goal;
        byte max=100; byte min=0;
        public byte Max
            {
            set {}
            get { return max; }
            }
        public byte Min
        {
            set { }
            get { return min; }
        }
        public byte Goal
        {
            get
            {
                return goal;
            }
            set { }
        }
        public bool MakeMove()
        {
            if (goal == assump) return true;
            else
                if (goal < assump) max = assump;
            else
                min = assump;
            return false;
        }

    }
}
