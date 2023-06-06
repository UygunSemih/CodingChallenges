namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp
    public class DetectPangram
    {
        // my solution
        private static List<char> alphabet = new List<char>()
                {
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
                };
        public static bool IsPangram(string str)
        {
            var letters = new List<char>(alphabet);
            var strLowered = str.ToLower();
            foreach(var letter in strLowered)
            {
                if (letters.Contains(letter))
                    letters.Remove(letter);
            }
            return letters.Count == 0;
        }

        // solution voted as best practice
        public static bool IsPangramBestPractice(string str)
        {
            return str.Where(ch => char.IsLetter(ch)).Select(ch => char.ToLower(ch)).Distinct().Count() == 26;
        }
    }
}
