using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask3
{
    class Complex
    {
        #region fields;
        double a;
        double b;
        #endregion;
        #region Constructors
        public Complex(double a, double b)
        {
            this.a = a; this.b = b;
        }
        public Complex()
        {
            a = 0; b = 0;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"({a},{b}i)";
        }
        public void add(Complex x)
        {
            this.a = a + x.a;
            this.b = b + x.b;
        }
        public void sub(Complex x)
        {
            this.a = a - x.a;
            this.b = b - x.b;
        }
        public void mul(Complex x)
        {
            this.a = a * x.a - b * x.b;
            this.b = b * x.a + a * x.b;
        }
        #endregion
        #region Operators
        public static Complex operator +(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.a = x.a + y.a;
            z.b = x.b + y.b;
            return z;
        }
        public static Complex operator -(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.a = x.a - y.a;
            z.b = x.b - y.b;
            return z;
        }
        public static Complex operator *(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.a = y.a * x.a - y.b * x.b;
            z.b = y.b * x.a + y.a * x.b;
            return z;
        }

        #endregion

    }
}
