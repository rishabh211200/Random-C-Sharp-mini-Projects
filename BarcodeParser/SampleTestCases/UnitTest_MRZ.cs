using NUnit.Framework;
using System;

namespace NUnitTestProject
{
    public class UnitTest_MRZ
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPositive()
        {
            string mrz = "P<UTOWALLET<<<<MART<JOHN<<<<<<<<<<<<<<<<<<<<PP12345674UTO7012257M2507315<ST082345Q<<<<26";
            MrzParser mrzParser = new MrzParser(mrz);
            Assert.IsNull(mrzParser.Error);
            Assert.AreEqual(mrzParser.DocumentCode, "P");
            Assert.AreEqual(mrzParser.IssuingState, "UTO");
            Assert.AreEqual(mrzParser.Name, "WALLET    MART JOHN");
            Assert.AreEqual(mrzParser.DocumentNumber, "PP1234567");
            Assert.AreEqual(mrzParser.CheckDigit1, 4);
            Assert.AreEqual(mrzParser.Nationality, "UTO");
            Assert.AreEqual(mrzParser.DateOfBirth, new DateTime(1970, 12, 25));
            Assert.AreEqual(mrzParser.CheckDigit2, 7);
            Assert.AreEqual(mrzParser.Sex, "M");
            Assert.AreEqual(mrzParser.DateOfExpirty, new DateTime(2025, 7, 31));
            Assert.AreEqual(mrzParser.CheckDigit3, 5);
            Assert.AreEqual(mrzParser.PersonalNumber, "ST082345Q");
            Assert.AreEqual(mrzParser.CheckDigit4, 2);
            Assert.AreEqual(mrzParser.CompositeCheckDigit, 6);
        }

        [Test]
        public void TestReadingErrorOutOfIndex()
        {
            string mrz = "P<UTOWALLET<<<<MART<JOHN<<<<<<<<<<<<<<<<<<<<";
            MrzParser parser = new MrzParser(mrz);
            Assert.IsNotNull(parser.Error);
            Assert.AreEqual("Error when reading source text, last field read was DocumentNumber, next string index is at 44", parser.Error);
            Assert.IsNotNull(parser.StackTrace);
        }

        [Test]
        public void TestReadingErrorIncorrectTypeInt()
        {
            string mrz = "P<UTOWALLET<<<<MART<JOHN<<<<<<<<<<<<<<<<<<<<PP1234567AUTO7012257M2507315<ST082345Q<<<<26";
            MrzParser parser = new MrzParser(mrz);
            Assert.IsNotNull(parser.Error);
            Assert.AreEqual("Error when parsing CheckDigit1", parser.Error);
            Assert.IsNotNull(parser.StackTrace);
        }

        [Test]
        public void TestReadingErrorIncorrectTypeDate()
        {
            string mrz = "P<UTOWALLET<<<<MART<JOHN<<<<<<<<<<<<<<<<<<<<PP12345674UTO7013257M2507315<ST082345Q<<<<26";
            MrzParser parser = new MrzParser(mrz);
            Assert.IsNotNull(parser.Error);
            Assert.AreEqual("Error when parsing DateOfBirth", parser.Error);
            Assert.IsNotNull(parser.StackTrace);
        }
    }
}
