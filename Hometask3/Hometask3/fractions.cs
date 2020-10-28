using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask3
{
    class fraction
    {
        public int a;
        private int b;
        public int c=0;
        public int _b
        {
            get { return b; }
            set
            {
                if (value == 0) throw new ArgumentException("Нулевой знаменатель");
                else b = value;
            }
        }
        private int NOD(int A, int B)
        {
            if (A < B) return NOD(A, B - A); else
            if (A > B) return NOD(A - B, B); else
                return A;   
        }
        private int NOK(int A, int B)
        {
            return A * B / NOD(A, B);
        }

        #region methods
        public void add(fraction x, fraction y)
        {
            x.toIncorrect(); y.toIncorrect();
            int nok = NOK(x.b, y.b);
            int mult1 = nok / x.b; int mult2 = nok / y.b;
            //fraction z = new fraction();
            a = x.a * mult1 + y.a * mult2;
            b = nok; 
        }

        public void sub(fraction x, fraction y)
        {
            y.a = -y.a;
            add(x, y);
        }
        public void mul(fraction x, fraction y)
        {
            x.toIncorrect(); y.toIncorrect();
            a = x.a * y.a;
            b = x.b * y.b;
        }
        public void div(fraction x, fraction y)
        {
            int k = y.a; y.a = y.b; y.b = y.a; //swaping numerator and denominator
            mul(x, y);
        }
        #endregion
        #region operators
        public static fraction operator +(fraction x, fraction y)
        {
            fraction z = new fraction();
            z.add(x, y);
            return z;
        }
        public static fraction operator -(fraction x, fraction y)
        {
            fraction z = new fraction();
            z.sub(x, y);
            return z;
        }
        public static fraction operator *(fraction x, fraction y)
        {
            fraction z = new fraction();
            z.mul(x, y);
            return z;
        }
        public static fraction operator /(fraction x, fraction y)
        {
            fraction z = new fraction();
            z.div(x, y);
            return z;
        }
        #endregion

        public void toProper()
        {
            c = a / b;
            a = a % b;
        }
        public void toIncorrect()
        {
            a = c * b + a;
            c = 0;
        }
        public void toReduce()
        {
            int nod=NOD(a, b);
            a = a / nod;
            b = b / nod;
        }
        public override string ToString()
        {

            if ((a < 0)&&(b < 0)) { a = -a; b = -b;} //to delete excess '-'
            if (c == 0) return $"{a} / {b}";
            else
            {
                if (a * b < 0) { c = -c; if (a < 0) a = -a; else b = -b; }//to remove '-' into whole part
                return $"{c} {a} / {b}";
            }
        }
    }
}
