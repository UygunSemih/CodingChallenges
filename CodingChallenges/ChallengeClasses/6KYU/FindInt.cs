namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp
    public class FindInt
    {
        // my solution
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(number => number).Where(number => number.Count() %2 != 0).Select(number => number.First()).First();
        }

        // solution voted as best practice
        public static int find_itBestPractice(int[] seq)
        {
            return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
    }
}
