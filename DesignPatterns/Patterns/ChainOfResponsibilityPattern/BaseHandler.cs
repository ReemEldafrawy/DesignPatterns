using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Chain_Of_Responsibility
{
    public abstract class BaseHandler
    {
        protected BaseHandler _Handler;
        public void SetHandler(BaseHandler handler)
        {
            _Handler = handler;

        }
        public abstract void HandleRequest(JopApplication jop);




    }
}
