using System;
using System.Collections.Generic;

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

        public override void Run()
        {
            base.Run();

        }
    }
}