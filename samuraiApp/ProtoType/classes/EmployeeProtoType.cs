using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.classes
{
    public abstract class EmployeeProtoType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }
        public abstract EmployeeProtoType ShallowCopy();
        public abstract EmployeeProtoType DeepCopy();
        public override string ToString()
        {
            return
                $@"
                   ID: {this.Id}
                   Name: {this.Name}
                   Address:{this.EmpAddress.City},{this.EmpAddress.StreetName},{this.EmpAddress.Bulding}";
        }
    }
}
