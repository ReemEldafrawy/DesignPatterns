using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Singleton
{
    //only create one instance of a class 
    public class Counter
    {


        public int Count = 0;
        private static Counter Instance = null;
        private static readonly object _lock = new object();
        private Counter() { }
        public static Counter GetInstance()
        {
            if (Instance == null)
            {
                lock (_lock)
                {
                    if (Instance == null)
                    { Instance = new Counter(); }

                }
           
            }
            return Instance;
        }
        public void AddCount()
        {
            Count++;
        }






    }
}
