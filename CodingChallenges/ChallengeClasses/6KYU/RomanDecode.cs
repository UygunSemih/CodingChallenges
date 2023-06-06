namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/51b6249c4612257ac0000005/train/csharp
    public class RomanDecode
    {
        // my solution
        private static List<char> symbols = new List<char>() { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        private static List<int> values = new List<int>() { 1, 5, 10, 50, 100, 500, 1000 };
        public static int Solution(string roman)
        {
            int total = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && values[symbols.IndexOf(roman[i])] < values[symbols.IndexOf(roman[i + 1])])
                {
                    total += values[symbols.IndexOf(roman[i + 1])] - values[symbols.IndexOf(roman[i])];
                    i++;
                }
                else
                    total += values[symbols.IndexOf(roman[i])];
            }
            return total;
        }

        // solution voted as best practice
        private static readonly Dictionary<char, int> literals = new Dictionary<char, int>
                {{'I', 1},{'V', 5},{'X', 10},{'L', 50},{'C', 100},{'D', 500},{'M', 1000},};
        public static int SolutionBestPractice(string roman)
        {
            int result = 0;
            int max = 0;

            foreach (var c in roman.Reverse())
            {
                int value = literals[c];

                if (value < max)
                {
                    result -= value;
                }
                else
                {
                    result += value;
                    max = value;
                }
            }
            return result;
        }
    }
}
