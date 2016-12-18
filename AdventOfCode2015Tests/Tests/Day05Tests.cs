using AdventOfCode2015.Solutions;
using Xunit;

namespace AdventOfCode2015Tests
{
    public class Day05Tests
    {
        [Fact]
        public void ExampleTest()
        {
            Assert.Equal(true, Day05.IsNice("ugknbfddgicrmopn"));
            Assert.Equal(true, Day05.IsNice("aaa"));
            Assert.Equal(false, Day05.IsNice("jchzalrnumimnmhp"));
            Assert.Equal(false, Day05.IsNice("haegwjzuvuyypxyu"));
            Assert.Equal(false, Day05.IsNice("dvszwmarrgswjxmb"));
        }

        [Fact]
        public void ExamplePart2Test()
        {
            Assert.Equal(true, Day05.IsNicePart2("qjhvhtzxzqqjkmpb"));
            Assert.Equal(true, Day05.IsNicePart2("xxyxx"));
            Assert.Equal(true, Day05.IsNicePart2("xxxxx"));
            Assert.Equal(false, Day05.IsNicePart2("uurcxstgmygtbstg"));
            Assert.Equal(false, Day05.IsNicePart2("ieodomkazucvgmuy"));
            Assert.Equal(false, Day05.IsNicePart2("mlpaqhnnkqxrmwmm"));
        }

    }
}
