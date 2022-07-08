using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Adapter
{
    public class SalaryAdapter: SalaryCalcolator
    {
        private Eployee _deployee=new Eployee();
        public double CalcSalary(MachineOperator eployee)
        {
            _deployee.BasicSalary = eployee.BasicSalary;
            return base.CalcSalary(_deployee);
        } 

    }
}
