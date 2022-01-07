using Xunit;

namespace XUnitEmptyParamsBug
{
    public class UnitTest1
    {
        [Theory]
        // This does not work either
        // [InlineData]
        [InlineData(new object[] {})]
        public void Test1(params string[] values)
        {
            Assert.Empty(values);
        }
    }
}
