using System;
using System.Collections.Generic;
using System.Text;

namespace Bai8
{
     public class NextDayCalculatorService
    {
        public DateTime nextDay(DateTime date)
        {

            return date.AddDays(1);
        }
    }
}
