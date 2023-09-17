using NUnit.Framework;
using Sita.Utils.Parser;
using System;

namespace NUnitTestProject
{

    class UnitTest_BCBP
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPlusPad()  /**/ 
        {
            string bcbp = "M1XIE/ZAIPENG+++++++++EMYK8BR+PEKLAXCA+0987+208Y033J0063+15D>5181O+0208BCA++++++++++++++2A999243176753702CA+CA+052002790109+++++2PCN*30600000K0901+++++++";
            var bcbpParser = new BcbpParser(bcbp, new DateTime(2020, 8, 15));
            Assert.AreEqual(bcbpParser.Format, "M");
            Assert.AreEqual(bcbpParser.NumberOfLegs, 1);
            Assert.AreEqual(bcbpParser.PassengerName, "XIE/ZAIPENG");
            Assert.AreEqual(bcbpParser.ETicketIndicator, "E");
            Assert.AreEqual(bcbpParser.PNR, "MYK8BR");
            Assert.AreEqual(bcbpParser.FromAirport, "PEK");
            Assert.AreEqual(bcbpParser.ToAirport, "LAX");
            Assert.AreEqual(bcbpParser.CarrierCode, "CA");
            Assert.AreEqual(bcbpParser.FlightNumber, "0987");
            Assert.AreEqual(bcbpParser.FlightDate, new DateTime(2020, 7, 26));
            Assert.AreEqual(bcbpParser.Compartment, "Y");
            Assert.AreEqual(bcbpParser.SeatNumber, "033J");
            Assert.AreEqual(bcbpParser.Sequence, 63);
            Assert.AreEqual(bcbpParser.PassengerStatus, "1");
        }

        [Test]
        public void TestBlankPad()
        {
            string bcbp = "M1WALL/MART           ENCJCON ISPHNDJL 0022 365Y002D0001 10";
            var bcbpParser = new BcbpParser(bcbp, new DateTime(2020, 8, 15));
            Assert.AreEqual(bcbpParser.Format, "M");
            Assert.AreEqual(bcbpParser.NumberOfLegs, 1);
            Assert.AreEqual(bcbpParser.PassengerName, "WALL/MART");
            Assert.AreEqual(bcbpParser.ETicketIndicator, "E");
            Assert.AreEqual(bcbpParser.PNR, "NCJCON");
            Assert.AreEqual(bcbpParser.FromAirport, "ISP");
            Assert.AreEqual(bcbpParser.ToAirport, "HND");
            Assert.AreEqual(bcbpParser.CarrierCode, "JL");
            Assert.AreEqual(bcbpParser.FlightNumber, "0022");
            Assert.AreEqual(bcbpParser.FlightDate, new DateTime(2020, 12, 30));
            Assert.AreEqual(bcbpParser.Compartment, "Y");
            Assert.AreEqual(bcbpParser.SeatNumber, "002D");
            Assert.AreEqual(bcbpParser.Sequence, 1);
            Assert.AreEqual(bcbpParser.PassengerStatus, "1");
        }

        [Test]
        public void TestJulianDate1()
        {
            string[] julianDates = { "2" };
            DateTime dt1 = new DateTime(2020, 1, 1);
            DateTime dt2 = new DateTime(2020, 1, 10);
            DateTime dt3 = new DateTime(2020, 4, 30);
            DateTime dt4 = new DateTime(2020, 6, 28);
            DateTime dt5 = new DateTime(2020, 7, 1);
            DateTime dt6 = new DateTime(2020, 10, 31);
            DateTime dt7 = new DateTime(2020, 12, 30);
            DateTime dt8 = new DateTime(2020, 12, 31);

            DateTime jd1 = FixPosParser.GetJulianDateField(julianDates, 0, dt1, (f,e) => { });
            Assert.AreEqual(jd1, new DateTime(2020, 1, 2));

            DateTime jd2 = FixPosParser.GetJulianDateField(julianDates, 0, dt2, (f, e) => { });
            Assert.AreEqual(jd2, new DateTime(2020, 1, 2));

            DateTime jd3 = FixPosParser.GetJulianDateField(julianDates, 0, dt3, (f, e) => { });
            Assert.AreEqual(jd3, new DateTime(2020, 1, 2));

            DateTime jd4 = FixPosParser.GetJulianDateField(julianDates, 0, dt4, (f, e) => { });
            Assert.AreEqual(jd4, new DateTime(2020, 1, 2));

            DateTime jd5 = FixPosParser.GetJulianDateField(julianDates, 0, dt5, (f, e) => { });
            Assert.AreEqual(jd5, new DateTime(2020, 1, 2));

            DateTime jd6 = FixPosParser.GetJulianDateField(julianDates, 0, dt6, (f, e) => { });
            Assert.AreEqual(jd6, new DateTime(2021, 1, 2));

            DateTime jd7 = FixPosParser.GetJulianDateField(julianDates, 0, dt7, (f, e) => { });
            Assert.AreEqual(jd7, new DateTime(2021, 1, 2));

            DateTime jd8 = FixPosParser.GetJulianDateField(julianDates, 0, dt8, (f, e) => { });
            Assert.AreEqual(jd8, new DateTime(2021, 1, 2));
        }

        [Test]
        public void TestJulianDate2()
        {
            string[] julianDates = { "182" };
            DateTime dt1 = new DateTime(2020, 1, 1);
            DateTime dt2 = new DateTime(2020, 1, 10);
            DateTime dt3 = new DateTime(2020, 4, 30);
            DateTime dt4 = new DateTime(2020, 6, 28);
            DateTime dt5 = new DateTime(2020, 7, 1);
            DateTime dt6 = new DateTime(2020, 10, 31);
            DateTime dt7 = new DateTime(2020, 12, 30);
            DateTime dt8 = new DateTime(2020, 12, 31);

            DateTime jd1 = FixPosParser.GetJulianDateField(julianDates, 0, dt1, (f, e) => { });
            Assert.AreEqual(jd1, new DateTime(2020, 6, 30));

            DateTime jd2 = FixPosParser.GetJulianDateField(julianDates, 0, dt2, (f, e) => { });
            Assert.AreEqual(jd2, new DateTime(2020, 6, 30));

            DateTime jd3 = FixPosParser.GetJulianDateField(julianDates, 0, dt3, (f, e) => { });
            Assert.AreEqual(jd3, new DateTime(2020, 6, 30));

            DateTime jd4 = FixPosParser.GetJulianDateField(julianDates, 0, dt4, (f, e) => { });
            Assert.AreEqual(jd4, new DateTime(2020, 6, 30));

            DateTime jd5 = FixPosParser.GetJulianDateField(julianDates, 0, dt5, (f, e) => { });
            Assert.AreEqual(jd5, new DateTime(2020, 6, 30));

            DateTime jd6 = FixPosParser.GetJulianDateField(julianDates, 0, dt6, (f, e) => { });
            Assert.AreEqual(jd6, new DateTime(2020, 6, 30));

            DateTime jd7 = FixPosParser.GetJulianDateField(julianDates, 0, dt7, (f, e) => { });
            Assert.AreEqual(jd7, new DateTime(2021, 7, 1));

            DateTime jd8 = FixPosParser.GetJulianDateField(julianDates, 0, dt8, (f, e) => { });
            Assert.AreEqual(jd8, new DateTime(2021, 7, 1));
        }

        [Test]
        public void TestJulianDate3()
        {
            string[] julianDates = { "365" };
            DateTime dt1 = new DateTime(2020, 1, 1);
            DateTime dt2 = new DateTime(2020, 1, 10);
            DateTime dt3 = new DateTime(2020, 4, 30);
            DateTime dt4 = new DateTime(2020, 6, 28);
            DateTime dt5 = new DateTime(2020, 7, 1);
            DateTime dt6 = new DateTime(2020, 10, 31);
            DateTime dt7 = new DateTime(2020, 12, 30);
            DateTime dt8 = new DateTime(2020, 12, 31);

            DateTime jd1 = FixPosParser.GetJulianDateField(julianDates, 0, dt1, (f, e) => { });
            Assert.AreEqual(jd1, new DateTime(2019, 12, 31));

            DateTime jd2 = FixPosParser.GetJulianDateField(julianDates, 0, dt2, (f, e) => { });
            Assert.AreEqual(jd2, new DateTime(2019, 12, 31));

            DateTime jd3 = FixPosParser.GetJulianDateField(julianDates, 0, dt3, (f, e) => { });
            Assert.AreEqual(jd3, new DateTime(2019, 12, 31));

            DateTime jd4 = FixPosParser.GetJulianDateField(julianDates, 0, dt4, (f, e) => { });
            Assert.AreEqual(jd4, new DateTime(2019, 12, 31));

            DateTime jd5 = FixPosParser.GetJulianDateField(julianDates, 0, dt5, (f, e) => { });
            Assert.AreEqual(jd5, new DateTime(2020, 12, 30));

            DateTime jd6 = FixPosParser.GetJulianDateField(julianDates, 0, dt6, (f, e) => { });
            Assert.AreEqual(jd6, new DateTime(2020, 12, 30));

            DateTime jd7 = FixPosParser.GetJulianDateField(julianDates, 0, dt7, (f, e) => { });
            Assert.AreEqual(jd7, new DateTime(2020, 12, 30));

            DateTime jd8 = FixPosParser.GetJulianDateField(julianDates, 0, dt8, (f, e) => { });
            Assert.AreEqual(jd8, new DateTime(2020, 12, 30));
        }

        [Test]
        public void TestJulianDate4()
        {
            string[] julianDates = { "366" };
            DateTime dt1 = new DateTime(2020, 1, 1);
            DateTime dt2 = new DateTime(2020, 1, 10);
            DateTime dt3 = new DateTime(2020, 4, 30);
            DateTime dt4 = new DateTime(2020, 6, 28);
            DateTime dt5 = new DateTime(2020, 7, 1);
            DateTime dt6 = new DateTime(2020, 10, 31);
            DateTime dt7 = new DateTime(2020, 12, 30);
            DateTime dt8 = new DateTime(2020, 12, 31);

            DateTime jd1 = FixPosParser.GetJulianDateField(julianDates, 0, dt1, (f, e) => { });
            Assert.AreEqual(jd1, new DateTime(2020, 1, 1));

            DateTime jd2 = FixPosParser.GetJulianDateField(julianDates, 0, dt2, (f, e) => { });
            Assert.AreEqual(jd2, new DateTime(2020, 1, 1));

            DateTime jd3 = FixPosParser.GetJulianDateField(julianDates, 0, dt3, (f, e) => { });
            Assert.AreEqual(jd3, new DateTime(2020, 1, 1));

            DateTime jd4 = FixPosParser.GetJulianDateField(julianDates, 0, dt4, (f, e) => { });
            Assert.AreEqual(jd4, new DateTime(2020, 1, 1));

            DateTime jd5 = FixPosParser.GetJulianDateField(julianDates, 0, dt5, (f, e) => { });
            Assert.AreEqual(jd5, new DateTime(2020, 1, 1));

            DateTime jd6 = FixPosParser.GetJulianDateField(julianDates, 0, dt6, (f, e) => { });
            Assert.AreEqual(jd6, new DateTime(2020, 12, 31));

            DateTime jd7 = FixPosParser.GetJulianDateField(julianDates, 0, dt7, (f, e) => { });
            Assert.AreEqual(jd7, new DateTime(2020, 12, 31));

            DateTime jd8 = FixPosParser.GetJulianDateField(julianDates, 0, dt8, (f, e) => { });
            Assert.AreEqual(jd8, new DateTime(2020, 12, 31));
        }
    }
}
