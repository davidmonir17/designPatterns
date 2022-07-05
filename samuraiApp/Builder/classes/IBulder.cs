using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
    public interface IBulder
    {
        void StartupOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadLieght();
        void EndOperations();
        Product GetVehicle();
    }
}
