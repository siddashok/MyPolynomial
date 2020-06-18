using System;
using System.Collections.Generic;
using System.Text;

namespace MyPolynomial
{
    class MyPolynomial
    {
        private readonly  double[] _coeffs;

        public MyPolynomial(double[] coeffs)
        {
            _coeffs = new double[coeffs.Length];

            for (int i = 0; i < coeffs.Length; i++)
            {
                _coeffs[i] = coeffs[i];
            }
        }

        int GetDegree()
        {
            return _coeffs.Length - 1;
        }

        public override String ToString()
        {
            String str = "";
            for (int i = _coeffs.Length - 1; i >= 0; i--) //5-1 = 4 i=4, i>=0;i-- 4,3,2,1,0
            {
                if (_coeffs[i] > 0)
                    str = str + "+" + _coeffs[i] + "x^" + i;
                else if (_coeffs[i] < 0)
                    str = str + _coeffs[i] + "x^" + i;
            }
            return str;
        }

        public  double Evaluate(double x)
        {
            double EvaluatedValue = 0;
            for (int i = 0; i < _coeffs.Length; i++)
            {
                EvaluatedValue += _coeffs[i] * Math.Pow(x, i);
            }
            return EvaluatedValue;
        }

        public MyPolynomial Add(MyPolynomial another)
        {
            int a = GetDegree();
            int b = another.GetDegree();
            int value;
            if (a <= b)
                value = b + 1;
            else
                value = a + 1;

            double[] NewPolynomial = new double[value];

            int i;
            for (i = 0; i < a + 1 && i < b + 1; i++)
            {
                NewPolynomial[i] = _coeffs[i] + another._coeffs[i];
            }

            for (; i < a + 1; i++)
            {
                NewPolynomial[i] = _coeffs[i];
            }

            for (; i < b + 1; i++)
            {
                NewPolynomial[i] = another._coeffs[i];
            }

            MyPolynomial SumPolynomial = new MyPolynomial(NewPolynomial);

            return SumPolynomial;
        }

        public MyPolynomial Multiply(MyPolynomial another)
        {
            int a = GetDegree();
            int b = another.GetDegree();
            int value = ((a + 1) * (b + 1)) + 1;

            double[] NewPolynomial = new double[value];

            for (int i = 0; i < a + 1; i++)
            {
                for (int j = 0; j < b + 1; j++)
                {
                    NewPolynomial[i + j] += _coeffs[i] * another._coeffs[j];
                }
            }

            MyPolynomial MultiplyPolynomial = new MyPolynomial(NewPolynomial);

            return MultiplyPolynomial;
        }
    }
}
