using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Facada_Pattern
{
    public class ShoppingBasket
    {

     private List<BasketItems> items=new List<BasketItems>();
     public void AddItem(BasketItems item)
        {

        items.Add(item); 
        }

        //check if item here or no
        public void RemoveItem(string itemid)
        {
            var item = items.Where(x =>x.Item_Id== itemid).Single();
            if(item.Item_Quantity>0)
            {
                item.Item_Quantity = item.Item_Quantity - 1;
            }
        }
        public List<BasketItems> GetItems()
        {
            return items;
        }














    }
}
