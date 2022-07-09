using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.FlyWeight
{
    public interface IDiscountCalcoulatr
    {
        double GetDiscountValue(DateTime dateTime, string ItemId);
    }
}
