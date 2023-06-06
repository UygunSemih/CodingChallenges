namespace CodingChallenges.ChallengeClasses._7KYU
{
    // challenge link https://www.codewars.com/kata/546e2562b03326a88e000020/train/csharp
    public class SquareDigits
    {
        // my solution
        public static int SquareDigit(int n)
        {
            string total = string.Empty;
            string number = n.ToString();
            foreach(char c in number)
            {
                total += (Char.GetNumericValue(c) * Char.GetNumericValue(c)).ToString();
            }
            return Convert.ToInt32(total);
        }

        // solution voted as best practice
        public static int SquareDigitsBestPractice(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += (square * square);
            }
            return int.Parse(output);
        }
    }
}
