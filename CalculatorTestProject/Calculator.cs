using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int addend, int secondAddend) => addend + secondAddend;

        public int Subtract(int minuend, int subtrahend) => minuend - subtrahend;

        public int Multiply(int factor, int secondFactor) => factor * secondFactor;

        public int Divide(int dividend, int divider) => dividend / divider;
    }
}
