using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.ChallengeClasses._5KYU
{
    // challenge link https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp
    public class PigLatin
    {
        // my solution
        public static string PigIt(string str)
        {
            string result = string.Empty;
            var split = str.Split(' ');
            foreach (var word in split)
            {
                if (!char.IsPunctuation(word[0])) 
                    result += word.Substring(1) + word[0] + "ay";
                else
                    result += word;
                result += ' ';
            }
            return result.TrimEnd();
        }


        // solution voted as best practice
        public static string PigItBestPractice(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
        }
    }
}
