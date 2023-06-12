
namespace CodingChallenges.ChallengeClasses._4KYU
{
    // challenge link https://www.codewars.com/kata/51ba717bb08c1cd60f00002f/train/csharp
    public class RangeExtraction
    {
        // my solution
        public static string Extract(int[] args)
        {
            if (args.Length == 0)
            {
                return string.Empty;
            }

            var result = new List<string>();
            int start = args[0];
            int prev = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] != prev + 1)
                {
                    if (prev - start >= 2)
                    {
                        result.Add($"{start}-{prev}");
                    }
                    else
                    {
                        for (int j = start; j <= prev; j++)
                        {
                            result.Add(j.ToString());
                        }
                    }
                    start = args[i];
                }
                prev = args[i];
            }

            if (prev - start >= 2)
            {
                result.Add($"{start}-{prev}");
            }
            else
            {
                for (int j = start; j <= prev; j++)
                {
                    result.Add(j.ToString());
                }
            }

            return string.Join(",", result);
        }


        // solution voted as best practice
        public int Value, Count;
        public int NextValue => Value + Count;

        public RangeExtraction(int value)
        {
            Value = value;
            Count = 1;
        }

        public override string ToString()
            => Count == 1 ? $"{Value}" :
               Count == 2 ? $"{Value},{Value + 1}" :
                            $"{Value}-{NextValue - 1}";

        public static string ExtractBestPractice(int[] args)
        {
            var list = new List<RangeExtraction>();

            foreach (var n in args)
                if (list.LastOrDefault()?.NextValue == n) list.Last().Count++;
                else list.Add(new RangeExtraction(n));

            return string.Join(",", list);
        }
    }
}
