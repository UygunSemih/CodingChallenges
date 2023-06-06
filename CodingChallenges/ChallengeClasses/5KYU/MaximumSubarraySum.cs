namespace CodingChallenges.ChallengeClasses._5KYU
{
    // challenge link https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c/train/csharp
    public class MaximumSubarraySum
    {
        // my solution
        public static int MaxSequence(int[] arr)
        {
            int biggest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int number = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    number += arr[j];
                    if(number > biggest)
                        biggest = number;
                }
            }
            return biggest;
        }

        // solution voted as best practice
        public static int MaxSequenceBestPractice(int[] arr)
        {
            int max = 0, res = 0, sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                max = sum > max ? max : sum;
                res = res > sum - max ? res : sum - max;
            }
            return res;
        }
    }
}
