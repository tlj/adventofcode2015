using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace AdventOfCode2015.Solutions
{
    public class Day05 : Base
    {

        public Day05(string dayInput)
        {
            Init(dayInput);
        }

        public Day05(bool isTest)
        {
            if (isTest)
            {
                Init(Inputs.Day05.testData);
            }
            else
            {
                Init(Inputs.Day05.realData);
            }
        }

        public static bool IsNice(string checkString)
        {
            var vowelCount = 0;
            var hasDoubles = false;
            char lastChar = ' ';
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var disallowed = new string[] { "ab", "cd", "pq", "xy" };

            for (var i = 0; i < checkString.Length; i++)
            {
                if (checkString[i] == lastChar)
                {
                    hasDoubles = true;
                }

                if (vowels.Contains(checkString[i]))
                {
                    vowelCount++;
                }

                lastChar = checkString[i];
            }

            foreach (var d in disallowed)
            {
                if (checkString.Contains(d))
                {
                    return false;
                }
            }

            return hasDoubles && vowelCount >= 3;
        }

        public static bool IsNicePart2(string checkString)
        {
            var pairs = new List<string>();
            var hasRepeatWithBetween = false;
            var hasRepeatedPair = false;
            char last = ' ';
            char secondLast = ' ';
            char thirdLast = ' ';
            for (var i = 0; i < checkString.Length; i++)
            {
                if (checkString[i] == secondLast)
                {
                    hasRepeatWithBetween = true;
                }
                if (!(checkString[i] == secondLast && (last == secondLast && last != thirdLast)))
                {
                    string pair = last + "" + checkString[i];
                    if (pairs.Contains(pair))
                    {
                        hasRepeatedPair = true;
                    } else
                    {
                        pairs.Add(pair);
                    }
                }

                thirdLast = secondLast;
                secondLast = last;
                last = (char)checkString[i];
            }

            return hasRepeatedPair && hasRepeatWithBetween;
        }

        public override void Run()
        {
            base.Run();

            var countV1 = 0;
            var countV2 = 0;
            foreach (var s in inputs)
            {
                if (IsNice(s))
                {
                    countV1++;
                }
                if (IsNicePart2(s))
                {
                    countV2++;
                }
            }

            firstResult = countV1.ToString();
            secondResult = countV2.ToString();
        }
    }
}