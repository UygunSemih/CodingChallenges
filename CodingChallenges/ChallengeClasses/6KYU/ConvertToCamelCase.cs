using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
    public class ConvertToCamelCase
    {
        // my solution
        public static string ToCamelCase(string str)
        {
            var ch = str.ToCharArray().ToList();
            for (int i = 0; i < ch.Count; i++)
            {
                if (!ch[i].Equals('-') && !ch[i].Equals('_'))
                    continue;
                ch[i + 1] = Convert.ToChar(ch[i + 1].ToString().ToUpper());
                ch.RemoveAt(i);
            }
            return new string(ch.ToArray());
        }

        // solution voted as best practice
        public static string ToCamelCaseBestPractice(string str)
        {
            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        }
    }
}
