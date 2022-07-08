using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Adapter
{
    public class SalaryCalcolator
    {
        public double CalcSalary(Eployee eployee) => eployee.BasicSalary * 1.5;
    }
}
