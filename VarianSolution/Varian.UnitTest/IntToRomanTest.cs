using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Varian.BusinessLogic;

namespace Varian.UnitTest
{
    [TestClass]
    public class IntToRomanTest
    {
        /// <summary>
        /// TestFourDigitsNumber - Test a four digits number
        /// </summary>
        [TestMethod]
        public void TestFourDigitsNumber()
        {
            // arrange  
            var number = 3999;
            var output = string.Empty;

            // act  
            try
            {
                output = Service.IntToRoman(number);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            // assert  
            Assert.AreEqual("MMM CM XC IX", output);
        }

        /// <summary>
        /// TestThreeDigitsNumber - Test a three digits number
        /// </summary>
        [TestMethod]
        public void TestThreeDigitsNumber()
        {
            // arrange  
            var number = 999;
            var output = string.Empty;

            // act  
            try
            {
                output = Service.IntToRoman(number);
            } catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            // assert  
            Assert.AreEqual("CM XC IX", output);
        }

        /// <summary>
        /// TestTwoDigitsNumber - Test a two digits number
        /// </summary>
        [TestMethod]
        public void TestTwoDigitsNumber()
        {
            // arrange  
            var number = 16;
            var output = string.Empty;

            // act  
            try
            {
                output = Service.IntToRoman(number);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            // assert  
            Assert.AreEqual("X VI", output);
        }

        /// <summary>
        /// TestOneDigitNumber - Test an one digit number
        /// </summary>
        [TestMethod]
        public void TestOneDigitNumber()
        {
            // arrange  
            var number = 3;
            var output = string.Empty;

            // act  
            try
            {
                output = Service.IntToRoman(number);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            // assert  
            Assert.AreEqual("III", output);
        }

        /// <summary>
        /// TestNumberLowerThanRange - Test a number lower than 1
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNumberLowerThanRange()
        {
            // arrange  
            var number = 0;
            var output = string.Empty;

            // act  
            output = Service.IntToRoman(number);

        }

        /// <summary>
        /// TestNumberGreaterThanRange - Test a number greater than 3999
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNumberGreaterThanRange()
        {
            // arrange  
            var number = 4999;
            var output = string.Empty;

            // act  
            output = Service.IntToRoman(number);
        }
    }
}
