using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singeleton
{
    public class counter
    {
        public int count = 0;
        private static counter instance = null;

        public static counter getInstance()
        {
            if (instance == null) { instance = new counter(); }
            return instance;
        }

        private counter()
        {
        }

        public void AddOne()
        { count++; }
    }
}