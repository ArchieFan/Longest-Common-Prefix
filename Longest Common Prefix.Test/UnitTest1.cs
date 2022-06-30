namespace Longest_Common_Prefix.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "ab", "a" }, "a")]
        public void XUnitTest(string[] inputarr, string expected)
        {
            Solution sol = new Solution();
            string result = sol.LongestCommonPrefix(inputarr);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "ab", "a" }, "a")]
        public void XUnitTest2(string[] inputarr, string expected)
        {
            Solution sol = new Solution();
            string result = sol.LongestCommonPrefix2(inputarr);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "ab", "a" }, "a")]
        public void XUnitTest3(string[] inputarr, string expected)
        {
            Solution sol = new Solution();
            string result = sol.LongestCommonPrefix3(inputarr);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "ab", "a" }, "a")]
        public void XUnitTest4(string[] inputarr, string expected)
        {
            Solution sol = new Solution();
            string result = sol.LongestCommonPrefix4(inputarr);
            Assert.Equal(expected, result);
        }
    }
}