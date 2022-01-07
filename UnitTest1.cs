using Xunit;

namespace XUnitEmptyParamsBug
{
    public class UnitTest1
    {
        [Theory]
        [InlineData]
        public void Test1(params string[] values)
        {
            Assert.Empty(values);
        }
    }
}
