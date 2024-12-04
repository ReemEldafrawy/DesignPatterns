using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Bulider
{
    public class Bike:IBuilder
    {
        public string Brand { get; set; }
        private Product p;
        public Bike(string brand)
        {
            Brand = brand;
            p = new Product();
        }
        public void StartUpOperations()
        {
            p.Add($"Bike Model name {this.Brand}");
        }
        public void BuildBody()
        {
            p.Add("Body of Bike is Added");
        }
        public void InsertWheels()
        {
            p.Add("Wheels are added");
        }
        public void AddHeadLights()
        {
            p.Add("Lights are added");
        }
        public void EndOperations()
        {

        }
        public Product GetProduct()
        {
            return p;
        }












































    }
}
