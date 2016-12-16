using System.Linq;
using System;

namespace AdventOfCode2015.Solutions
{
    public class Day01 : Base
    {

        public Day01(string dayInput)
        {
            Init(dayInput);
        }

        public Day01(bool isTest)
        {
            if (isTest)
            {
                Init(Inputs.Day01.testData);
            }
            else
            {
                Init(Inputs.Day01.realData);
            }
        }

        public override void Run()
        {
            base.Run();

            firstResult = (input.Count(f => f == '(') - input.Count(f => f == ')')).ToString();

            var floor = 0;
            var position = 0;
            for (position = 0; position < input.Length; position++)
            {
                floor += (input[position] == '(') ? 1 : -1;
                Console.WriteLine((position + 1) + ": " + floor);
                if (floor == -1) break;
            }
            secondResult = (position + 1).ToString();

        }
    }
}