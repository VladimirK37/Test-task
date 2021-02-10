using ShapeUtilLibrary;
using Xunit;

namespace ShapeUtilLibraryTests
{
    public class HelpUtilTest
    {
        [Fact]
        public void TestSwapVariables()
        {
            //Arrange
            double var1 = 4;
            double var2 = 5;

            //Act
            HelpUtil.SwapVariables(ref var1, ref var2);

            //Assert
            Assert.Equal(4, var2);
            Assert.Equal(5, var1);
        }
    }
}
