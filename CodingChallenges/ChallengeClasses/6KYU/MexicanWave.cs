namespace CodingChallenges.ChallengeClasses._6KYU
{
    // challenge link https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/train/csharp
    public class MexicanWave
    {
        // my solution
        public List<string> wave(string str)
        {
            var list = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(' '))
                    continue;
                char[] ch = str.ToCharArray();
                ch[i] = Convert.ToChar(ch[i].ToString().ToUpper());
                list.Add(new string(ch));
            }
            return list;
        }

        // solution voted as best practice
        public List<string> waveBestPractice(string str) =>
          str
            .Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
            .Where(x => x != str)
            .ToList();
    }
}
