using System.Text;

namespace CodingChallenges.ChallengeClasses
{
    // challenge link https://www.codewars.com/kata/546e2562b03326a88e000020/train/csharp
    // challenge rank: 7KYU
    public class Accumul
    {
        // my solution
        public static string Accum(string s)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = System.Convert.ToChar(s[i].ToString().ToLower());
                string word = s[i].ToString().ToUpper() + new string(c,i);
                sb.Append(word);
                if (i < s.Length - 1)
                    sb.Append("-");
            }
            return sb.ToString();
        }

        // solution voted as best practice
        public static String AccumBestPractice(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }
    }
}
