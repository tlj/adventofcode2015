using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2015.Solutions
{
    public class Day02 : Base
    {

        public Day02(string dayInput)
        {
            Init(dayInput);
        }

        public Day02(bool isTest)
        {
            if (isTest)
            {
                Init(Inputs.Day02.testData);
            }
            else
            {
                Init(Inputs.Day02.realData);
            }
        }

        public int SquareFeetOfPaperNeeded(int l, int w, int h)
        {
            var numbers = new int[] { l * w, w * h, h * l };
            var smallest = numbers.Min();

            return ((2 * l * w) + (2 * w * h) + (2 * h * l)) + smallest;
        }

        public int LengthOfRibbonNeeded(int l, int w, int h)
        {
            var numbers = new int[] { l, w, h };
            var numbersOrdered = numbers.OrderBy(c => c);
            var smallest = numbersOrdered.First();
            var nextSmallest = numbersOrdered.Skip(1).First();

            var bow = l * w * h;
            var ribbon = (smallest * 2) + (nextSmallest * 2);

            return bow + ribbon;
        }

        public override void Run()
        {
            base.Run();
            
            var squareFeet = 0;
            var ribbonFeet = 0;
            foreach (var line in inputs)
            {
                var nums = line.Split('x');
                squareFeet += SquareFeetOfPaperNeeded(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]));
                ribbonFeet += LengthOfRibbonNeeded(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]));
            }
            firstResult = squareFeet.ToString();
            secondResult = ribbonFeet.ToString();
        }
    }
}