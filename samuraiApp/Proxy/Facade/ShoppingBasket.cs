using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Facade
{
    public class ShoppingBasket
    {
        private List<BasketItem> _items= new List<BasketItem>();
        public void AddItem(BasketItem item)
        {
            _items.Add(item);
        }
        public void RemoveOneItem(int id)
        {
            var item = _items.Where(x=>x.ItemId == id).FirstOrDefault();
            if(item != null && item.Quantity > 0)
            {
                item.Quantity = item.Quantity - 1;
            }
        }
        public List<BasketItem> GetBasketItems() { return _items; }
    }
}
