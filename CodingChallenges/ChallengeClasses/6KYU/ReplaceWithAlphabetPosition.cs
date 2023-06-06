using System.Text;

namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
    public class ReplaceWithAlphabetPosition
    {
        // my solution
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public static string AlphabetPosition(string text)
        {
            var sb = new StringBuilder();
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (!alphabet.Contains(text[i]))
                    continue;
                sb.Append(alphabet.IndexOf(text[i])+1);
                if(i <= text.Length - 1)
                    sb.Append(' ');
            }
            return sb.ToString().TrimEnd();
        }

        // solution voted as best practice
        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
    }
}
