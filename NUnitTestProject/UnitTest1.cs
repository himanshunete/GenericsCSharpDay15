using NUnit.Framework;
using Generic;

namespace NUnitTestProject
{
    public class Tests
    {
        MaxThreeNumbers maxThreeNumbers;

        [SetUp]
        public void Setup()
        {
            maxThreeNumbers = new MaxThreeNumbers() ;
        }

        /// <summary>
        /// TC-1.1 Test max at 1st position
        /// </summary>
        [Test]
        public void Given3IntegerNumbers_WhenAt1stPosition_ShouldReturnMaxValue()
        {
            int result = maxThreeNumbers.MaxOfThreeNumbers(89, 23, 65);
            Assert.AreEqual(89, result);
        }

        /// <summary>
        /// TC-1.2 Test max at 2nd position
        /// </summary>
        [Test]
        public void Given3IntegerNumbers_WhenAt2ndPosition_ShouldReturnMaxValue()
        {
            int result = maxThreeNumbers.MaxOfThreeNumbers(23, 89, 65);
            Assert.AreEqual(89, result);
        }

        /// <summary>
        /// TC-1.3 Test max at 3rd position
        /// </summary>
        [Test]
        public void Given3IntegerNumbers_WhenAt3rdPosition_ShouldReturnMaxValue()
        {
            int result = maxThreeNumbers.MaxOfThreeNumbers(23, 65, 89);
            Assert.AreEqual(89, result);
        }

        /// <summary>
        /// TC-2.1 Test max at 1st position
        /// </summary>
        [Test]
        public void Given3FloatNumbers_WhenAt1stPosition_ShouldReturnMaxValue()
        {
            float result = maxThreeNumbers.MaxOfThreeFloats(22.03f, 13.98f, 6.34f);
            Assert.AreEqual(22.03f, result);
        }

        /// <summary>
        /// TC-2.2 Test max at 2nd position
        /// </summary>
        [Test]
        public void Given3FloatNumbers_WhenAt2ndPosition_ShouldReturnMaxValue()
        {
            float result = maxThreeNumbers.MaxOfThreeFloats(13.98f, 22.08f, 6.34f);
            Assert.AreEqual(22.03f, result);
        }

        /// <summary>
        /// TC-2.3 Test max at 3rd position
        /// </summary>
        [Test]
        public void Given3FloatNumbers_WhenAt3rdPosition_ShouldReturnMaxValue()
        {
            float result = maxThreeNumbers.MaxOfThreeFloats(13.98f, 6.34f, 22.08f);
            Assert.AreEqual(22.03f, result);
        }
    }
}