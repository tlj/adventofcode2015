using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace AdventOfCode2015.Solutions
{
    public class Day04 : Base
    {

        public Day04(string dayInput)
        {
            Init(dayInput);
        }

        public Day04(bool isTest)
        {
            if (isTest)
            {
                Init(Inputs.Day04.testData);
            }
            else
            {
                Init(Inputs.Day04.realData);
            }
        }

        public override void Run()
        {
            base.Run();

            var md5 = MD5.Create();
            var index = 0;
            var hash = Utils.MD5.CalculateMd5(input + index, md5);
            while (hash.Substring(0, 5) != "00000")
            {
                hash = Utils.MD5.CalculateMd5(input + ++index, md5);
            }
            firstResult = index.ToString();

            index = 0;
            hash = Utils.MD5.CalculateMd5(input + index, md5);
            while (hash.Substring(0, 6) != "000000")
            {
                hash = Utils.MD5.CalculateMd5(input + ++index, md5);
            }
            secondResult = index.ToString();
        }
    }
}