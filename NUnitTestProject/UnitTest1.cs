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

        /// <summary>
        /// TC-3.1, 3.2, 3.3  Test max 
        /// </summary>
        [TestCase("pineapple","apple","orange")]
        [TestCase("apple", "pineapple", "orange")]
        [TestCase("apple", "orange", "pineapple")]
        public void Given3Strings_WhenAtDifferentPositions_ShouldReturnMaxValue(string first, string second, string third)
        {
            string result = maxThreeNumbers.MaxOfThreeString(first, second, third);
            Assert.AreEqual("pineapple", result);
        }

        /// <summary>
        /// TC-4.1, 4.2, 4.3 to test max integer
        /// </summary>
        
        [TestCase(89, 23, 65, 12)]
        [TestCase(23, 89, 65)]
        [TestCase(89, 65, 89)]
        public void Given3Values_WhenAtDifferentPositions_ShouldReturnMaxValue(int[] value )
        { 
            Assert.AreEqual(89, Generic<int>.MaxAmongThreeGenericInput(value));
        }

        /// <summary>
        /// TC-4.1, 4.2, 4.3 to test max float
        /// </summary>

        [TestCase(22.03f, 13.98f, 6.34f)]
        [TestCase(13.98f, 22.03f, 6.34f)]
        [TestCase(22.03f, 6.34f, 22.08f)]
        public void Given3Values_WhenAtDifferentPositions_ShouldReturnMaxValue(float[] value)
        {
            Assert.AreEqual(22.03f, Generic<float>.MaxAmongThreeGenericInput(value));
        }


        /// <summary>
        /// TC-4.1, 4.2, 4.3 to test max string
        /// </summary>
        [TestCase("pineapple", "apple", "orange")]
        [TestCase("apple", "pineapple", "orange")]
        [TestCase("apple", "orange", "pineapple")]
        public void Given3Values_WhenAtDifferentPositions_ShouldReturnMaxValue(string[] value)
        {
            Assert.AreEqual("pineapple", Generic<string>.MaxAmongThreeGenericInput(value));
        }



    }
}