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
            switch (args[0])
            {
                case "day01":
                    new Day01(isTest).Output();
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }
        }
    }
}
