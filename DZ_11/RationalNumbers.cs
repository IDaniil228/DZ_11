using System;

namespace DZ_11
{
    [DeveloperInfo("Разработчик", "2024.7.01")]
    internal class RationalNumbers
    {
        private int numerator { get; set; }
        private int denominator { get; set; }
        public RationalNumbers(int a, int b)
        {
            numerator = a;
            denominator = b;
        }


        public static bool operator ==(RationalNumbers a, RationalNumbers b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(RationalNumbers a, RationalNumbers b)
        {
            return !(a == b);
        }

        public static bool operator >(RationalNumbers a, RationalNumbers b)
        {
            if (Math.Round((double)a.numerator / a.denominator, 5) > Math.Round((double)b.numerator / b.denominator, 5))
            {
                return true;
            }
            return false;
        }
        public static bool operator <(RationalNumbers a, RationalNumbers b)
        {
            if (Math.Round((double)a.numerator / a.denominator, 5) < Math.Round((double)b.numerator / b.denominator, 5))
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(RationalNumbers a, RationalNumbers b)
        {
            if (Math.Round((double)a.numerator / a.denominator, 5) <= Math.Round((double)b.numerator / b.denominator, 5))
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(RationalNumbers a, RationalNumbers b)
        {
            if (Math.Round((double)a.numerator / a.denominator, 5) >= Math.Round((double)b.numerator / b.denominator, 5))
            {
                return true;
            }
            return false;
        }

        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
        {
            int temp = a.denominator * b.denominator;
            int temp_1 = a.numerator * (temp / a.denominator);
            int temp_2 = b.numerator * (temp / b.denominator);
            RationalNumbers result = new RationalNumbers(temp_1 + temp_2, temp);
            return result;
        }

        public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b)
        {
            int temp = a.denominator * b.denominator;
            int temp_1 = a.numerator * (temp / a.denominator);
            int temp_2 = b.numerator * (temp / b.denominator);
            RationalNumbers result = new RationalNumbers(temp_1 - temp_2, temp);
            return result;
        }

        public static RationalNumbers operator ++(RationalNumbers a)
        {
            int temp_1 = 1 * a.denominator;
            RationalNumbers result = new RationalNumbers(a.numerator + temp_1, a.denominator);
            return result;
        }
        public static RationalNumbers operator --(RationalNumbers a)
        {
            int temp_1 = 1 * a.denominator;
            RationalNumbers result = new RationalNumbers(a.numerator - temp_1, a.denominator);
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj is RationalNumbers numb)
            {
                if (Math.Round((double)numerator / denominator, 5) == Math.Round((double)numb.numerator / numb.denominator, 5))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

    }
}
