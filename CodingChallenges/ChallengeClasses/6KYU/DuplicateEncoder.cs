using System.Text;

namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
    public class DuplicateEncoder
    {
        // my solution
        public static string DuplicateEncode(string word)
        {
            var sb = new StringBuilder();
            word = word.ToLower();
            foreach (var c in word)
            {
                if(word.Count(x => x == c) > 1)
                {                    
                    sb.Append(')');
                    continue;
                }
                sb.Append('(');
            }
            return sb.ToString();
        }

        // solution voted as best practice
        public static string DuplicateEncodeBestPractice(string word)
        {
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }
    }
}
