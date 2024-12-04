using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Bulider
{
    public class Product
    {

        private LinkedList<string> parts;
        public Product()
        {
            parts = new LinkedList<string>();
        }
        public void Add(string p)
        {
            parts.AddLast(p);
        }
        public string show()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"product Combonents are:");
            foreach (string part in parts)
            {
                result.AppendLine(part);
            }
            return result.ToString();   

        }


























    }
}
