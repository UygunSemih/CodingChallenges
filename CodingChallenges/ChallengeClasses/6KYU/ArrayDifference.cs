namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
    public class ArrayDifference
    {
        // my solution
        public static int[] ArrayDiff(int[] a, int[] b)
        {            
            return a.Where(x => !b.Contains(x)).Select(x => x).ToArray();
        }

        // solution voted as best practice
        public static int[] ArrayDiffBestPractice(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}
