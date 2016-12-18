using AdventOfCode2015.Solutions;
using Xunit;

namespace AdventOfCode2015Tests
{
    public class Day06Tests
    {
        [Fact]
        public void TuronOnAllTest()
        {
            var expected = 1000000;
            var actual = Day06.CountLights(Day06.ToggleLights(new bool[1000, 1000], "turn on 0,0 through 999,999"));
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TuronOnFirstLineTest()
        {
            var expected = 1000;
            var actual = Day06.CountLights(Day06.ToggleLights(new bool[1000, 1000], "turn on 0,0 through 999,0"));
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TurnOnAllThenOffMiddleFourTest()
        {
            var expected = 1000000 - 4;

            var lights = Day06.ToggleLights(new bool[1000, 1000], "turn on 0,0 through 999,999");
            Assert.Equal(1000000, Day06.CountLights(lights));

            lights = Day06.ToggleLights(lights, "turn off 499,499 through 500,500");
            Assert.Equal(expected, Day06.CountLights(lights));
        }

        [Fact]
        public void BrightNessTest()
        {
            var expected = 1;
            var lights = Day06.ToggleLightsPart2(new int[1000, 1000], "turn on 0,0 through 0,0");

            Assert.Equal(expected, Day06.MeasureBrightness(lights));
        }

        [Fact]
        public void BrightNess2Test()
        {
            var expected = 2000000;
            var lights = Day06.ToggleLightsPart2(new int[1000, 1000], "toggle 0,0 through 999,999");

            Assert.Equal(expected, Day06.MeasureBrightness(lights));
        }

        [Fact]
        public void TurnOnAllThenOffMiddleFour2Test()
        {
            var expected = 1000000 - 4;

            var lights = Day06.ToggleLightsPart2(new int[1000, 1000], "turn on 0,0 through 999,999");
            Assert.Equal(1000000, Day06.MeasureBrightness(lights));

            lights = Day06.ToggleLightsPart2(lights, "turn off 499,499 through 500,500");
            Assert.Equal(expected, Day06.MeasureBrightness(lights));
        }

        [Fact]
        public void TurnOnAllThenToggleMiddleFour2Test()
        {
            var expected = 1000000 + 8;

            var lights = Day06.ToggleLightsPart2(new int[1000, 1000], "turn on 0,0 through 999,999");
            Assert.Equal(1000000, Day06.MeasureBrightness(lights));

            lights = Day06.ToggleLightsPart2(lights, "toggle 499,499 through 500,500");
            Assert.Equal(expected, Day06.MeasureBrightness(lights));
        }

        [Fact]
        public void TurnOnAllThenIncreaseMiddleFour2Test()
        {
            var expected = 1000000 + 4;

            var lights = Day06.ToggleLightsPart2(new int[1000, 1000], "turn on 0,0 through 999,999");
            Assert.Equal(1000000, Day06.MeasureBrightness(lights));

            lights = Day06.ToggleLightsPart2(lights, "turn on 499,499 through 500,500");
            Assert.Equal(expected, Day06.MeasureBrightness(lights));
        }
    }
}
