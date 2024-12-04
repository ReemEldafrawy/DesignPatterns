using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Facada_Pattern
{
    public class InventoryOrder
    {

public string CreateOrder(ShoppingBasket shoppingBasket)
        {
            shoppingBasket.GetItems();
            return $"Order items are {System.Guid.NewGuid().ToString()}";
        }




    }
}
