using System.Numerics;

namespace CodingChallenges.ChallengeClasses._4KYU
{
    // challenge link https://www.codewars.com/kata/5324945e2ece5e1f32000370/train/csharp
    public class SumStringsAsNumbers
    {
        // my solution
        public static string sumStrings(string a, string b)
        {
            var a1 = BigInteger.Zero;
            var b1 = BigInteger.Zero;
            BigInteger.TryParse(a, out a1);
            BigInteger.TryParse(b, out b1);
            return (a1+b1).ToString();
        }

        public static string sumStringsWithoutBigInt(string a, string b)
        {
            if (a.Length != b.Length)
            {
                if (a.Length > b.Length)
                    b = b.PadLeft(a.Length, '0');
                else
                    a = a.PadLeft(b.Length, '0');
            }
            string result = string.Empty;
            int rest = 0;
            for (int i = a.Length - 1; i > -1; i--)
            {
                int sum = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString()) + rest;
                rest = 0;
                if(sum >= 10 && i - 1 > -1)
                {
                    rest = 1;
                    sum -= 10;
                }
                result = result.Insert(0,sum.ToString());
            }
            return result.TrimStart('0');
        }


        // solution voted as best practice
        public static string sumStringsBestPractice(string a, string b)
        {
            BigInteger aInt;
            BigInteger bInt;

            BigInteger.TryParse(a, out aInt);
            BigInteger.TryParse(b, out bInt);

            return (aInt + bInt).ToString();
        }
    }
}
