using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.FlyWeight
{
    public class DayDiscountCalc : IDiscountCalcoulatr
    {
        public double GetDiscountValue(DateTime dateTime, string ItemId)
        {
            return 0.15;
        }
    }
}
