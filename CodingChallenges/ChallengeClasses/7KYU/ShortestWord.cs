namespace CodingChallenges.ChallengeClasses._7KYU
{
    // challenge link https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9/train/csharp
    public class ShortestWord
    {
        // my solution
        public static int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }

        // solution voted as best practice
        public static int FindShortBestPractice(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }
    }
}
