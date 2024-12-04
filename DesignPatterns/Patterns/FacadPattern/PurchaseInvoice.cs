using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Facada_Pattern
{
    public class PurchaseInvoice
    {



        public double Discount = 0;
        public double TotalAmount = 0;
        public double NetTotal = 0;


        public PurchaseInvoice CreateInvoice(ShoppingBasket basket, string CustomerInFo)
        {
            var invoice = new PurchaseInvoice();
            var items = basket.GetItems();
            foreach (BasketItems item in items)
            {
                invoice.TotalAmount = item.Item_Price * item.Item_Quantity;
            }
            if (items.Count > 0)
            {
                invoice.Discount = 20;
            }
            invoice.NetTotal = invoice.TotalAmount - invoice.Discount;
            return invoice;


        }
    }
}
