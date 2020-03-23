using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1Test
{
    [TestClass]
    public class EuclideanGCDTests
    {
        [TestMethod]
        public void GradestCommonDivisor150And325And875And250Returned25()
        {
            // Arrange
            int[] arr = new int[] { 150, 325, 875, 250 };
            // Act
            int result = EuclideanGCD.GradestCommonDivisor(arr);
            // Assert
            Assert.AreEqual( 25, result, "GradestCommonDivisor150And325And875And250Returned25 test failed");
        }

        public void BinaryGradestCommonDivisor126And784And210Returned14()
        {
            // Arrange
            int[] arr = new int[] { 126, 784, 210 };
            // Act
            int result = EuclideanGCD.BinaryGradestCommonDivisor(arr);
            // Assert
            Assert.AreEqual(14, result, "BinaryGradestCommonDivisor126And784And210Returned14 test failed");
        }
    }
}
