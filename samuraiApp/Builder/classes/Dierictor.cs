using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
    public class Dierictor
    {
        IBulder bulder;
        public void Construct(IBulder bulder)
        {
            this.bulder = bulder;
            bulder.StartupOperations();
            bulder.BuildBody();
            bulder.InsertWheels();
            bulder.AddHeadLieght();
            bulder.EndOperations();
        }
    }
}
