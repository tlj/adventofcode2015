using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2015.Solutions
{
    public class Day03 : Base
    {

        public Day03(string dayInput)
        {
            Init(dayInput);
        }

        public Day03(bool isTest)
        {
            if (isTest)
            {
                Init(Inputs.Day03.testData);
            }
            else
            {
                Init(Inputs.Day03.realData);
            }
        }

        public Dictionary<string, int> Visited(int x, int y, string directions)
        {
            var hasVisited = new Dictionary<string, int>();

            hasVisited.Add(x + "x" + y, 1);
            foreach (var c in directions)
            {
                switch (c)
                {
                    case '^':
                        y--;
                        break;
                    case '>':
                        x++;
                        break;
                    case 'v':
                        y++;
                        break;
                    case '<':
                        x--;
                        break;
                }
                var key = x + "x" + y;
                if (!hasVisited.ContainsKey(key))
                {
                    hasVisited.Add(key, 0);
                }
                hasVisited[key]++;
            }
            return hasVisited;
        }

        public override void Run()
        {
            base.Run();

            firstResult = Visited(0, 0, input).Count.ToString();

            var santaDirections = "";
            var roboDirections = "";
            for (var i = 0; i < input.Length; i+=2)
            {
                santaDirections += input[i];
                roboDirections += input[i + 1];
            }

            var santaVisited = Visited(0, 0, santaDirections);
            var roboVisited = Visited(0, 0, roboDirections);

            var visited = santaVisited;
            foreach (var sv in roboVisited)
            {
                if (!visited.ContainsKey(sv.Key))
                {
                    visited.Add(sv.Key, sv.Value);
                }
            }
            secondResult = visited.Count.ToString();
        }
    }
}