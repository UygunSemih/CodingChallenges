namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/5544c7a5cb454edb3c000047/train/csharp
    public class BouncingBall
    {
        // my solution
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || (bounce <= 0 || bounce >= 1) || window >= h)
                return -1;

            int totalPasses = 0;
            while (h > window)
            {
                totalPasses++;
                h *= bounce;
                if (h > window)
                    totalPasses++;
            }
            return totalPasses;
        }

        // solution voted as best practice
        public static int bouncingBallBestPractice(double h, double bounce, double window)
        {
            if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h) return -1;
            int result = -1;

            do
            {
                result += 2;
                h *= bounce;
            } while (h > window);

            return result;
        }
    }
}
