using Testlib;
using Xunit;

namespace Testlib.Tests
{
    public class TestStringLibrary
    {
        [Theory]
        [InlineData("Alphabet", true)]
        [InlineData("alphabet", false)]
        [InlineData("1234", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void TestStartsWithUpper(string input, bool expected)
        {
            bool result = input.StartsWithUpper();
            Assert.Equal(expected, result);
        }
    }
}