namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp
    public class ConsecutiveStrings
    {
        // my solution
        public static string LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0 || k > strarr.Length || k <= 0)
                return string.Empty;
            string biggestword = string.Empty;
            for (int i = 0; i < strarr.Length; i ++)
            {
                var word = string.Empty;
                for (int j = i; j < i+k && j < strarr.Length; j++)
                {
                    word += strarr[j];
                }            
                if (word.Length > biggestword.Length)
                    biggestword= word;
            }
            return biggestword;
        }


        // solution voted as best practice

    }
}
