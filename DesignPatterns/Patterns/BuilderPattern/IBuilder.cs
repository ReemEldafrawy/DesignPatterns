using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Bulider
{
    public interface IBuilder
    {

        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadLights();
        void EndOperations();
        Product GetProduct();




















    }
}
