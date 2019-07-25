using BillPaying;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPay_Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IfDueDateIsBusinessDay_ReturnDueDate()
        {
            DateTime dueDate = new DateTime(2019, 7, 18);
            DateTime expectedDueDate = new DateTime(2019, 7, 18);
            Bill bill = new Bill();

            Assert.That(expectedDueDate, Is.EqualTo(bill.GetDueDate(dueDate)));
        }

        [Test]
        [TestCase("2019, 7, 20","2019, 7, 22")]
        [TestCase("2019, 7, 21", "2019, 7, 22")]
        [TestCase("2019, 7, 19", "2019, 7, 22")]
        public void IfDueDateIsOnWeekend_ReturnNextBusinessDay(string date, string expectedDueDate)
        {
            Bill bill = new Bill();
            DateTime dueDate = bill.GetDueDate(DateTime.Parse(date));

            Assert.That(dueDate, Is.EqualTo(DateTime.Parse(expectedDueDate)));
        }

        [Test]
        [TestCase("2019, 7, 4", "2019, 7, 5")]
        public void IfDueDateIsOnHoliday_ReturnNextBusinessDay(string date, string expectedDueDate)
        {
            HolidayService fakeHoliday = new HolidayService();
            fakeHoliday.AddHolidayToList(DateTime.Parse(date));

            Bill bill = new Bill();
            // bill needs to know about list from holiday service
            //bill.holidayList.isHoliday(date);

            DateTime dueDate = bill.GetDueDate(DateTime.Parse(date));
            
            Assert.That(dueDate, Is.EqualTo(DateTime.Parse(expectedDueDate)));
        }


    }
}
