using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Facade
{
    public class PurshceOrder
    {
        public bool CreateOrder(ShoppingBasket basket, string custInfo)
        {
            Inventory inventory = new Inventory();
            foreach (var item in basket.GetBasketItems())
            {if(!inventory.CheackItem(item.ItemId,item.Quantity))
                {
                    basket.RemoveOneItem(item.ItemId);
                }

            }
            InventoryOrder inventoryOrder = new InventoryOrder();
            inventoryOrder.CreateOrder(basket);
            
            PurshaseInvoice invoice = new PurshaseInvoice();
           var inv= invoice.CreateInvoice(basket, "address:7a sabry street");

            PaymentProcess paymentProcess = new PaymentProcess();
            paymentProcess.HandelPayment(inv.NetTotal, "acc=dsdasd 5545");
            return true;
        }
    }
}
