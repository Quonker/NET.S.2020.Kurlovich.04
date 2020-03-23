using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace Task2Test
{
    [TestClass]
    public class DoubleExtensionTests
    {
        [TestMethod]
        public void ConvertDoubleToBinaryStringNegativeDouble()
        {
            // Arrange
            double number =  -255.255;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("1100000001101111111010000010100011110101110000101000111101011100", result, "ConvertDoubleToBinaryStringNegativeDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringPositiveDouble()
        {
            // Arrange
            double number = 255.255;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("0100000001101111111010000010100011110101110000101000111101011100", result, "ConvertDoubleToBinaryStringPositiveDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringLongDouble()
        {
            // Arrange
            double number = 4294967295.0;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("0100000111101111111111111111111111111111111000000000000000000000", result, "ConvertDoubleToBinaryStringLongDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringMinValueDouble()
        {
            // Arrange
            double number = double.MinValue;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("1111111111101111111111111111111111111111111111111111111111111111", result, "ConvertDoubleToBinaryStringMinValueDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringMaxValueDouble()
        {
            // Arrange
            double number = double.MaxValue;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("0111111111101111111111111111111111111111111111111111111111111111", result, "ConvertDoubleToBinaryStringMaxValueDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringEpsilonDouble()
        {
            // Arrange
            double number = double.Epsilon;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000001", result, "ConvertDoubleToBinaryStringEpsilonDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringNaNDouble()
        {
            // Arrange
            double number = double.NaN;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("1111111111111000000000000000000000000000000000000000000000000000", result, "ConvertDoubleToBinaryStringNaNDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringPositiveInfinityDouble()
        {
            // Arrange
            double number = double.PositiveInfinity;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("0111111111110000000000000000000000000000000000000000000000000000", result, "ConvertDoubleToBinaryStringPositiveInfinityDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringNegativeInfinityDouble()
        {
            // Arrange
            double number = double.NegativeInfinity;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("1111111111110000000000000000000000000000000000000000000000000000", result, "ConvertDoubleToBinaryStringNegativeInfinityDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringZeroDouble()
        {
            // Arrange
            double number = 0.0;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", result, "ConvertDoubleToBinaryStringZeroDouble test failed");
        }
        [TestMethod]
        public void ConvertDoubleToBinaryStringNegativeZeroDouble()
        {
            // Arrange
            double number = -0.0;
            // Act
            string result = number.ConvertDoubleToBinaryString();
            // Assert
            Assert.AreEqual("1000000000000000000000000000000000000000000000000000000000000000", result, "ConvertDoubleToBinaryStringNegativeZeroDouble test failed");
        }

    }


}
