namespace CodingChallenges.ChallengeClasses._5KYU
{
    // challenge link https://www.codewars.com/kata/550f22f4d758534c1100025a/train/csharp
    public class DirectionsReduction
    {
        // my solution
        public static string[] dirReduc(String[] arr)
        {
            bool canSimplified;
            string[] oppositesNS = new string[2] { "NORTH", "SOUTH" };
            string[] oppositesWE = new string[2] { "EAST", "WEST" };
            List<string> simplifiedList = new List<string>(arr);
            do
            {
                canSimplified = false;
                for (int i = 0; i < simplifiedList.Count - 1; i++)
                {
                    if (oppositesNS.Contains(simplifiedList[i]) && oppositesNS.Contains(simplifiedList[i + 1])
                        && (Array.IndexOf(oppositesNS, simplifiedList[i]) != Array.IndexOf(oppositesNS, simplifiedList[i + 1])))
                    {
                        simplifiedList.RemoveRange(i, 2);
                        canSimplified = true;
                        continue;

                    }
                    else if (oppositesWE.Contains(simplifiedList[i]) && oppositesWE.Contains(simplifiedList[i + 1])
                        && (Array.IndexOf(oppositesWE, simplifiedList[i]) != Array.IndexOf(oppositesWE, simplifiedList[i + 1])))
                    {
                        simplifiedList.RemoveRange(i, 2);
                        canSimplified = true;
                        continue;
                    }
                }

            } while (canSimplified);
            return simplifiedList.ToArray();
        }

        // solution voted as best practice
        public static String[] dirReducBestPractice(String[] arr)
        {
            Stack<String> stack = new Stack<String>();

            foreach (String direction in arr)
            {
                String lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;

                switch (direction)
                {
                    case "NORTH": if ("SOUTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "SOUTH": if ("NORTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "EAST": if ("WEST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "WEST": if ("EAST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                }
            }
            String[] result = stack.ToArray();
            Array.Reverse(result);

            return result;
        }
    }
}
