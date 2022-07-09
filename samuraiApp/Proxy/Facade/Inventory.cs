using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Facade
{
    public class Inventory
    {
        public bool CheackItem(int ItemId,double quantity)
        {
            return quantity < 100;
        }
    }
}
