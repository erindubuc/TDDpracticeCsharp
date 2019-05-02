using NUnit.Framework;
using PaymentDateCheck;
using System;
using System.Collections.Generic;

namespace Tests
{    
    [TestFixture]
    public class BillShould
    {
        [Test]
        public void IfBussinessDay_ReturnDueDate()
        {
            var input = new DateTime(2018,8,6);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill();
            var output = _bill.CheckDate(input);
            var expected = input;
            Assert.AreEqual(expected, output);
        }

        
        [Test]
        public void IfSaturday_ReturnMonday()
        {
            var input = new DateTime(2019, 5, 4);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill();
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2019, 5, 6);
            Assert.AreEqual(expected, output);
        }

        
        [Test]
        public void IfSunday_ReturnMonday()
        {
            var input = new DateTime(2019, 5, 5);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill();
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2019, 5, 6);
            Assert.AreEqual(expected, output);
        }

        
        [Test]
        public void IfHoliday_ReturnNonHoliday()
        {
            var input = new DateTime(2018, 12, 25);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill();
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2018, 12, 26);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void IfHoliday_ReturnWeekday()
        {
            var input = new DateTime(2018, 8, 3);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill();
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2018, 8, 6);
            Assert.AreEqual(expected, output);
        }
    }
}
 