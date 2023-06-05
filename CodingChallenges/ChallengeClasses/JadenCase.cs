using System.Globalization;
using System.Text;

namespace CodingChallenges.ChallengeClasses
{
    // challenge link https://www.codewars.com/kata/5390bac347d09b7da40006f6/train/csharp
    // challenge rank: 7KYU
    public static class JadenCase
    {
        // my solution
        public static string ToJadenCase(this string phrase)
        {
            var splitPhrase = phrase.Split(' ');
            var sb = new StringBuilder();
            for (int i = 0; i < splitPhrase.Length; i++)
            {                
                sb.Append(splitPhrase[i][0].ToString().ToUpper() + splitPhrase[i].Substring(1));
                if(i < splitPhrase.Length - 1)
                    sb.Append(" ");
            }
            return sb.ToString();
        }

        // solution voted as best practice
        public static string ToJadenCaseBestPractice(this string phrase)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }
    }
}
