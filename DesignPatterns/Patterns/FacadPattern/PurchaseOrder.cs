using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Facada_Pattern
{
    public class PurchaseOrder
    {

public bool CreateOrder(ShoppingBasket basket, string customerinfo)
        {



            bool IsAvailable = true;

            //check stock
            Inventory inventory = new Inventory();
            foreach (var item in basket.GetItems())
            {
                if (!inventory.CheckItemQuantity(item.Item_Id, item.Item_Quantity))
                {
                  IsAvailable = false;
                }

            }
            if (IsAvailable)
            {
                //create inventoryorder
                InventoryOrder inventoryOrder = new InventoryOrder();
                inventoryOrder.CreateOrder(basket);



                //create Invoice
                PurchaseInvoice purchaseInvoice = new PurchaseInvoice();
                var inv = purchaseInvoice.CreateInvoice(basket, "name:Reem Eldafdrawy ,Country in Egypt , myphone is 01101958909");



                //payment
                PaymentProcessor paymentProcessor = new PaymentProcessor();
                paymentProcessor.HandlePayment(inv.NetTotal, "num of bank :01101958909");


                //send notification
                SmsNotification smsNotification = new SmsNotification();
                smsNotification.Send("123", "than you very much");



                return true;


            }
            else
            {
                return false;
            }



















        }



















    }
}
