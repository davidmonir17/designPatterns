using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
    public class Product
    {
        private LinkedList<string> parts;

        public Product()
        {
            parts = new LinkedList<string>();
        }
        public void Add(string part)
        {
            parts.AddLast(part);
        }
        public string show()
        {
            StringBuilder result=new StringBuilder();
            result.AppendLine("Product components are : ");
            foreach (string part in parts)
                result.AppendLine(part);
            return result.ToString();
        }
    }
}
