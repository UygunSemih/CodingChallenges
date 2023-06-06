namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp
    public class SupermarketQueue
    {
        // my solution
        public static long QueueTime(int[] customers, int n)
        {
            int[] tills = new int[n];
            for (int i = 0; i < n; i++)
            {
                tills[i] = 0;
            }
            foreach (int customer in customers)
            {
                int quickest = Array.IndexOf(tills, tills.Min());
                tills[quickest] += customer;
            }
            return tills.Max();
        }

        // solution voted as best practice
        public static long QueueTimeBestPractice(int[] customers, int n)
        {
            var registers = new List<int>(Enumerable.Repeat(0, n));

            foreach (int cust in customers)
            {
                registers[registers.IndexOf(registers.Min())] += cust;
            }
            return registers.Max();
        }
    }
}
