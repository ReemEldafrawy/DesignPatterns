// See https://aka.ms/new-console-template for more information
namespace Example_Of_Facada_Pattern
{


public class oop
    {

public static void Main(string[] args)
        {


ShoppingBasket basket = new ShoppingBasket();
            basket.AddItem(new BasketItems { Item_Id = "123", Item_Price = 50, Item_Quantity = 3 });
            basket.AddItem(new BasketItems { Item_Id = "120", Item_Price = 20, Item_Quantity = 2});
            basket.AddItem(new BasketItems { Item_Id = "125", Item_Price = 60, Item_Quantity = 9 });

            PurchaseOrder purchaseOrder = new PurchaseOrder();
            purchaseOrder.CreateOrder(basket, "name:Reem Eldafrawy,num of bank:123,mobilephone:01101958909");

























            ////create basket

            //ShoppingBasket basket = new ShoppingBasket();
            //BasketItems basketItems = new BasketItems();
            //            basketItems.Item_Id = "1";
            //            basketItems.Item_Price = 50;
            //            basketItems.Item_Quantity = 3;


            ////check stock
            //Inventory inventory = new Inventory();
            //if(inventory.CheckItemQuantity(basketItems.Item_Id,basketItems.Item_Quantity))
            //            {
            //                basket.AddItem(basketItems);
            //            }



            ////create inventoryorder
            //InventoryOrder inventoryOrder = new InventoryOrder();
            //            inventoryOrder.CreateOrder(basket);



            ////create Invoice
            //PurchaseInvoice purchaseInvoice = new PurchaseInvoice();
            //            var inv=  purchaseInvoice.CreateInvoice(basket, "name:Reem Eldafdrawy ,Country in Egypt , myphone is 01101958909");



            ////payment
            //PaymentProcessor paymentProcessor = new PaymentProcessor();
            //            paymentProcessor.HandlePayment(inv.NetTotal, "num of bank :01101958909");


            //            //send notification
            //SmsNotification smsNotification = new SmsNotification();
            //            smsNotification.Send("123", "than you very much");






















        }



























    }


























}
