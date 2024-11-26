using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAndSortingEg
{
    public class Calculator
    {
        public double Value { get; }

        public Calculator(double value)
        {
            Value = value;
        }

        public static Calculator operator +(Calculator a, Calculator b)
        {
            return Add(a , b);
        }
        public static Calculator Add(Calculator a, Calculator b)
        {
            return new Calculator(a.Value + b.Value);

        }

        public static Calculator operator -(Calculator a, Calculator b)
        {
            return Subtract(a, b);
        }

        public static Calculator Subtract(Calculator a, Calculator b)
        {
            return new Calculator(a.Value - b.Value);

        }


        public static Calculator operator *(Calculator a, Calculator b)
        {
            return Multiply(a, b);
        }

        public static Calculator Multiply(Calculator a, Calculator b)
        {
            return new Calculator(a.Value * b.Value);
        }

        public static Calculator operator /(Calculator a, Calculator b)
        {

            return Divide(a, b);
        }

        public static Calculator Divide(Calculator a, Calculator b)
        {
            if (b.Value == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return new Calculator(a.Value / b.Value);
        }

    }
}
