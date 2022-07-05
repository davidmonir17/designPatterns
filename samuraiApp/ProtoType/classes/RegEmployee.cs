using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.classes
{
    public class RegEmployee : EmployeeProtoType
    {
        public override EmployeeProtoType DeepCopy()
        {
            RegEmployee employee = new RegEmployee();
            employee= (RegEmployee)this.MemberwiseClone();
            employee.EmpAddress = new Address
            {
                Bulding = EmpAddress.Bulding,
                StreetName = EmpAddress.StreetName,
                City = EmpAddress.City
            };
            employee.Name=this.Name;
            return employee;
        }

        public override EmployeeProtoType ShallowCopy()
        {
            return(RegEmployee) this.MemberwiseClone();
        }
    }
}
