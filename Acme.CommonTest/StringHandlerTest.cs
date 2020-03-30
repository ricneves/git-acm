using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //--Arrange
            var source = "SonicDriver";
            var expected = "Sonic Driver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //-- arrange
            var source = "Sonic Driver";
            var expected = "Sonic Driver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
