using AdventOfCode2015.Solutions;
using System;

namespace AdventOfCode2015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isTest = false;
            if (args.Length > 1 && args[1] == "test")
            {
                isTest = true;
            }
            if (args.Length < 1)
            {
                Console.WriteLine("Please add dayXX as param.");
                return;
            }
            Console.WriteLine("Running " + args[0] + " " + (isTest ? "test" : "real") + "\n");
            switch (args[0])
            {
                case "day01":
                    new Day01(isTest).Output();
                    break;
                case "day02":
                    new Day02(isTest).Output();
                    break;
                case "day03":
                    new Day03(isTest).Output();
                    break;
                case "day04":
                    new Day04(isTest).Output();
                    break;
                case "day05":
                    new Day05(isTest).Output();
                    break;
                case "day06":
                    new Day06(isTest).Output();
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }
        }
    }
}
