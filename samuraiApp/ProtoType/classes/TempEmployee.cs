using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.classes
{
    public class TempEmployee : EmployeeProtoType
    {
        public override EmployeeProtoType DeepCopy()
        {
            TempEmployee emp = new TempEmployee();
            emp=(TempEmployee)this.MemberwiseClone();
            emp.EmpAddress = new Address
            {
                Bulding = EmpAddress.Bulding,
                City = EmpAddress.City,
                StreetName = EmpAddress.StreetName
            };
            emp.Name=this.Name;
            return emp;
        }

        public override EmployeeProtoType ShallowCopy()
        {
            return (TempEmployee)this.MemberwiseClone();
        }
    }
}
