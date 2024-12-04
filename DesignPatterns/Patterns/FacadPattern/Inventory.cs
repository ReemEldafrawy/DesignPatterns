using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Facada_Pattern
{
    public class Inventory
    {
        //هنا بتاكد ان الكمية دي موجودة في المخزن ولا اي وطبعا دا باضافة شروط وكميات من كل فئة في الداتا بيز 
        public bool CheckItemQuantity(string itemid,double quantity)
        {
            return quantity < 100;
        }





    }
}
