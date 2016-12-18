using System.Linq;
using System;
using System.Collections.Generic;

namespace AdventOfCode2015.Solutions
{
    public class Day06 : Base
    {
        public Day06(string dayInput)
        {
            Init(dayInput);
        }

        public Day06(bool isTest)
        {
            if (isTest)
            {
                Init(Inputs.Day06.testData);
            }
            else
            {
                Init(Inputs.Day06.realData);
            }
        }      
        
        public static Dictionary<string, string> GetInstructions(string instructions)
        {
            string[] strings = instructions.Split(' ');

            string instruction = "";
            string[] start = new string[2];
            string[] end = new string[2];

            switch (strings[0])
            {
                case "toggle":
                    instruction = "toggle";
                    start = strings[1].Split(',');
                    end = strings[3].Split(',');
                    break;
                case "turn":
                    start = strings[2].Split(',');
                    end = strings[4].Split(',');
                    instruction = strings[1];
                    break;
            }

            var startX = start[0];
            var startY = start[1];
            var endX = end[0];
            var endY = end[1];

            return new Dictionary<string, string>() { { "instruction", instruction }, { "startX", startX }, { "startY", startY }, { "endX", endX }, { "endY", endY } };
        }  

        public static bool[,] ToggleLights(bool[,] lights, string instructionString)
        {
            var instructions = GetInstructions(instructionString);

            for (var y = int.Parse(instructions["startY"]); y <= int.Parse(instructions["endY"]); y++)
            {
                for (var x = int.Parse(instructions["startX"]); x <= int.Parse(instructions["endX"]); x++)
                {
                    switch (instructions["instruction"])
                    {
                        case "on":
                            lights[y, x] = true;
                            break;
                        case "off":
                            lights[y, x] = false;
                            break;
                        case "toggle":
                            lights[y, x] = !lights[y, x];
                            break;
                    }
                }
            }

            return lights;
        }

        public static int[,] ToggleLightsPart2(int[,] lights, string instructionString)
        {
            var instructions = GetInstructions(instructionString);

            for (var y = int.Parse(instructions["startY"]); y <= int.Parse(instructions["endY"]); y++)
            {
                for (var x = int.Parse(instructions["startX"]); x <= int.Parse(instructions["endX"]); x++)
                {
                    switch (instructions["instruction"])
                    {
                        case "on":
                            lights[y, x] += 1;
                            break;
                        case "off":
                            if (lights[y, x] > 0)
                            {
                                lights[y, x] -= 1;
                            }
                            break;
                        case "toggle":
                            lights[y, x] += 2;
                            break;
                        default:
                            throw new Exception("Invalid instruction " + instructions["instruction"]);
                    }
                }
            }

            return lights;
        }

        public static int CountLights(bool[,] lights)
        {
            var count = 0;
            for (var y = 0; y < lights.GetLength(0); y++) {
                for (var x = 0; x < lights.GetLength(1); x++)
                {
                    if (lights[y, x])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int MeasureBrightness(int[,] lights)
        {
            var brightness = 0;
            for (var y = 0; y < lights.GetLength(0); y++)
            {
                for (var x = 0; x < lights.GetLength(1); x++)
                {
                    brightness += lights[y, x];
                }
            }
            return brightness;
        }

        public override void Run()
        {
            base.Run();

            var lights = new bool[1000, 1000];
            foreach (var l in inputs)
            {
                lights = ToggleLights(lights, l);
            }

            firstResult = CountLights(lights).ToString();

            var lightsWithBrightness = new int[1000, 1000];
            foreach (var l in inputs)
            {
                lightsWithBrightness = ToggleLightsPart2(lightsWithBrightness, l);
            }
            secondResult = MeasureBrightness(lightsWithBrightness).ToString();
        }
    }
}