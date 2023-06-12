using System.Numerics;

namespace CodingChallenges.ChallengeClasses._4KYU
{
    // challenge link https://www.codewars.com/kata/5324945e2ece5e1f32000370/train/csharp
    public class SumStringsAsNumbers
    {
        // my solution
        public static string sumStrings(string a, string b)
        {

            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }


        // solution voted as best practice
        public static int GetLastDigitBestPractice(BigInteger n1, BigInteger n2)
        {
            return (int)BigInteger.ModPow(n1, n2, 10);
        }
    }
}
