using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesForWords()
        {
            //Arrange

            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            


            //Act
            var actual = source.InsertSpacesInWords();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesForWordsWithExistingSpaces()
        {
            //Arrange

            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            


            //Act
            var actual = source.InsertSpacesInWords();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
