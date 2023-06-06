using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.ChallengeClasses._7KYU
{
    // challenge link https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp
    public class MiddleCharacter
    {
        // my solution
        public static string GetMiddle(string s)
        {
            if(s.Length % 2 == 0)
            {
                return s.Substring(s.Length / 2 - 1, 2);
            }
            return s[s.Length / 2].ToString();            
        }

        // solution voted as best practice
        public static string GetMiddleBestPractice(string s)
        {
            return string.IsNullOrEmpty(s)
                ? s
                : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
        }
    }
}
