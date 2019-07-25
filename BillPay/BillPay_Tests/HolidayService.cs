using BillPaying;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPay_Tests
{
    public class HolidayService : IHolidayService
    {
        public List<DateTime> listOfHolidays;

        public void AddHolidayToList(DateTime holidayDate)
        {
            listOfHolidays = new List<DateTime>();
            listOfHolidays.Add(holidayDate);
        }

        public bool isHoliday(DateTime dueDate)
        {
            if (listOfHolidays.Contains(dueDate))
                return true;

            return false;
        }
    }
}
