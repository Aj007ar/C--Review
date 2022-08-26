using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyWageForEmployee
{
    public class CompanyWage
    {
        public string company;
        public int WagePrHr;
        public int MaxHrPrMonth;
        public int MaxWorkingDays;
        public int TotalWage;
        public CompanyWage(string company, int WagePrHr, int MaxHrPrMonth, int MaxWorkingDays)
        {
            this.company = company;
            this.WagePrHr = WagePrHr;
            this.MaxHrPrMonth = MaxHrPrMonth;
            this.MaxWorkingDays = MaxWorkingDays;
        }
        public void setTotalEmpWage(int TotalWage)
        {
            this.TotalWage = TotalWage;
        }
        public string toString() //getting total wage for multiple company
        {
            return "Total Employee Wage for " + this.company + " is " + this.TotalWage;
        }
    }
}
