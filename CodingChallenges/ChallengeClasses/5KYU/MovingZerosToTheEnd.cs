using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.ChallengeClasses._5KYU
{
    // challenge link https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
    public class MovingZerosToTheEnd
    {
        // my solution
        public static int[] MoveZeroes(int[] arr)
        {
            var list = new List<int>(arr);
            list.RemoveAll(x => x == 0);
            while (list.Count < arr.Length)
            {
                list.Add(0);
            }
            return list.ToArray();
        }


        // solution voted as best practice
        public static int[] MoveZeroesBestPractice(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
