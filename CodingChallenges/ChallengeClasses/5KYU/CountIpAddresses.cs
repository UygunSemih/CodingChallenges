using System.Net;

namespace CodingChallenges.ChallengeClasses._5KYU
{
    // challenge link https://www.codewars.com/kata/526989a41034285187000de4/train/csharp
    public class CountIpAddresses
    {
        // my solution
        public static long IpsBetween(string start, string end)
        {
            var splitStart = start.Split('.');
            var splitEnd = end.Split(".");

            long total = 0;
            total += long.Parse(splitEnd[3]) - long.Parse(splitStart[3]);
            total += (long.Parse(splitEnd[2]) - long.Parse(splitStart[2])) * 256;
            total += (long.Parse(splitEnd[1]) - long.Parse(splitStart[1])) * 256 * 256;
            total += (long.Parse(splitEnd[0]) - long.Parse(splitStart[0])) * 256 * 256 * 256;
            return total;
        }

        // solution voted as best practice
        public static long IpsBetweenBestPractice(string start, string end)
        {
            return (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(end).Address) -
                   (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(start).Address);
        }
    }
}
