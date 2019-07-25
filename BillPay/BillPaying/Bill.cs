using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPaying
{
    public class Bill
    {
        public IHolidayService holidayList;

        public DateTime GetDueDate(DateTime dueDate)
        {
            if (dueDate.DayOfWeek == DayOfWeek.Friday)
                return dueDate.AddDays(3);
            if (dueDate.DayOfWeek == DayOfWeek.Saturday)
                return dueDate.AddDays(2);
            if (dueDate.DayOfWeek == DayOfWeek.Sunday)
                return dueDate.AddDays(1);

            return dueDate;
        }
    }
}
