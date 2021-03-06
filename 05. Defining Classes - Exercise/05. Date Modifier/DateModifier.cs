using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefineClassPerson
{
    public class DateModifier
    {
        public int GetDaysDifference(string startDateString, string endDateString)
        {
            DateTime startDate = DateTime.Parse(startDateString);
            DateTime endDate = DateTime.Parse(endDateString);

            int totalDays = (int)(startDate - endDate).TotalDays;
            return totalDays;
        }
    }
}
