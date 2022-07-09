using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Facade
{
    public class InventoryOrder
    {
        public string CreateOrder(ShoppingBasket basket)
        {
            basket.GetBasketItems();
            return $"order Number Is {Guid.NewGuid().ToString()}";
        }
    }
}
