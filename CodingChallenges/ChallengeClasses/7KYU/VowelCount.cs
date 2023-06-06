namespace CodingChallenges.ChallengeClasses._7KYU
{
    // challenge link https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp
    public class VowelCount
    {
        // my solution
        public static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        public static int GetVowelCount(string str)
        {
            return str.Count(x=> vowels.Contains(x));
        }

        // solution voted as best practice
        public static int GetVowelCountBestPractice(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }
    }
}
