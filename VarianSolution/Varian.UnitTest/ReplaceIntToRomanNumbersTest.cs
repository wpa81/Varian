using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Varian.BusinessLogic;
using Varian.BusinessLogic.Model;

namespace Varian.UnitTest
{
    [TestClass]
    public class ReplaceIntToRomanNumbersTest
    {
        /// <summary>
        /// TestCase1
        /// </summary>
        [TestMethod]
        public void TestCase1()
        {
            // arrange  
            var input = "Lorem ipsum 2 dolor sit amet.";
            ReplaceIntToRomanNumberOutput output = null;

            // act  
            try
            {
                 output = Service.ReplaceIntToRomanNumber(input);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            // assert  
            Assert.IsNotNull(output);
            Assert.AreEqual("Lorem ipsum II dolor sit amet.", output.NewString);
            Assert.AreEqual(1, output.NumberOfReplacements);
        }

        /// <summary>
        /// TestCase2
        /// </summary>
        [TestMethod]
        public void TestCase2()
        {
            // arrange  
            var input = "Consectetur 5 adipiscing elit 9.";
            ReplaceIntToRomanNumberOutput output = null;

            // act  
            try
            {
                output = Service.ReplaceIntToRomanNumber(input);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            // assert  
            Assert.IsNotNull(output);
            Assert.AreEqual("Consectetur V adipiscing elit IX.", output.NewString);
            Assert.AreEqual(2, output.NumberOfReplacements);
        }

        /// <summary>
        /// TestCase3
        /// </summary>
        [TestMethod]
        public void TestCase3()
        {
            // arrange  
            var input = "Ut enim quis nostrum 1904 qui.";
            ReplaceIntToRomanNumberOutput output = null;

            // act  
            try
            {
                output = Service.ReplaceIntToRomanNumber(input);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            // assert  
            Assert.IsNotNull(output);
            Assert.AreEqual("Ut enim quis nostrum M CM IV qui.", output.NewString);
            Assert.AreEqual(1, output.NumberOfReplacements);
        }
    }
}
