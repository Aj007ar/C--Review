using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyWageForEmployee
{
    public interface IEmployWage //interface class
    {
        public void AddEmpWage(string company, int WagePrHr, int MaxHrPrMonth, int MaxWorkingDays);
        public void ComputeEmpWage();
        abstract int ComputeEmpWage(CompanyWage companyWage);
    }
}
