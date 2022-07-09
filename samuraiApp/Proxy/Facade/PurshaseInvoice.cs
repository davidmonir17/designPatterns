using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Facade
{
    public class PurshaseInvoice
    {
        public double discount = 0;
        public double totalAmmount = 0;
        public double NetTotal = 0;
        public PurshaseInvoice CreateInvoice(ShoppingBasket basket , string cusId)
        {
            var Invoice = new PurshaseInvoice();
            var items = basket.GetBasketItems();
            foreach(var item in items)
            {
                Invoice.totalAmmount += item.ItemPrice * item.Quantity;

            }
            if (items.Count > 5) Invoice.discount = 20;
            Invoice.NetTotal = Invoice.totalAmmount - Invoice.discount;
            return Invoice;
        }
    }
}
