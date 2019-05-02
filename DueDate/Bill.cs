using System;

namespace PaymentDateCheck
{
    public class Bill
    {
        //bring in holiday service to check for holidays
        //use dependency injection
        private IHolidayService _holidayService = new HolidayService();
        
        public DateTime CheckDate (DateTime dueDate)
        {
            if(dueDate.DayOfWeek == DayOfWeek.Saturday)
            {
                return dueDate.AddDays(2);
            }

            if (dueDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return dueDate.AddDays(1);
            }

            if (_holidayService.isHoliday(dueDate) == true && dueDate.DayOfWeek == DayOfWeek.Friday)
            {
                return dueDate.AddDays(3);
            }
            else if(_holidayService.isHoliday(dueDate) == true)
            {
                return dueDate.AddDays(1);
            }

            return dueDate;
        }
    }
}

