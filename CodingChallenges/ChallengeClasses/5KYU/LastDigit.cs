using System.Numerics;

namespace CodingChallenges.ChallengeClasses._5KYU
{
    // challenge link https://www.codewars.com/kata/5511b2f550906349a70004e1/train/csharp
    public class LastDigit
    {
        // my solution
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
            return (int)BigInteger.ModPow(n1, n2,BigInteger.Parse("10"));
        }


        // solution voted as best practice
        public static int GetLastDigitBestPractice(BigInteger n1, BigInteger n2)
        {
            return (int)BigInteger.ModPow(n1, n2, 10);
        }
    }
}
