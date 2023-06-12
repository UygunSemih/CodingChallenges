using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.ChallengeClasses._5KYU
{
    // challenge link https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp
    public class HumanReadableTime
    {
        // my solution
        public static string GetReadableTime(int seconds)
        {
            var t = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }


        // solution voted as best practice
        public static string GetReadableTimeBestPractice(int seconds)
        {
            return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }
    }
}
