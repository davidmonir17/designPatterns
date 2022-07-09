using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.FlyWeight
{
    public class DiscountCalcFactory
    {
        public IDiscountCalcoulatr GetDiscountCalc(string calcType)
        {
            IDiscountCalcoulatr calcoulatr = null;
            Dictionary<string, IDiscountCalcoulatr> clcList = new Dictionary<string, IDiscountCalcoulatr>();
            if(clcList.ContainsKey(calcType))
            {
                return clcList[calcType];
            }
            else { 
            switch (calcType)
            {
                case "day":
                    calcoulatr = new DayDiscountCalc();
                     clcList.Add(calcType, calcoulatr);   
                    break;
                case "item":
                    calcoulatr = new ItemDiscountCalc();
                        clcList.Add(calcType, calcoulatr);
                    break;
            }
            return calcoulatr;
            }
        }
    }
}
