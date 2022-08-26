using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyWageForEmployee
{
    public class EmployeeWage:IEmployWage
    {
        public const int Full_Time= 1;
        public const int Part_Time= 2;
        public int No_Of_Company = 0;
        public CompanyWage[] companyWageArray;

        
        public EmployeeWage()
        {
            this.companyWageArray = new CompanyWage[5];
        }
        public void AddEmpWage(string company,int WagePrHr,int MaxHrPrMonth,int MaxWorkingDays) // getting employee data using parameters
        {
            companyWageArray[this.No_Of_Company] = new CompanyWage(company, WagePrHr, MaxHrPrMonth, MaxWorkingDays);
            No_Of_Company++;
        }
        public void ComputeEmpWage() //getting employee wage for multiple company
        {
            for(int i = 0; i < No_Of_Company; i++)
            {
                companyWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyWageArray[i]));
                Console.WriteLine(this.companyWageArray[i].toString());
            }
        }
        public int ComputeEmpWage(CompanyWage companyWage) //calculate wage for employee
        {
            int empHrs = 0, TotalHrs = 0, TotalWorkDays = 0;
            while(TotalHrs<=companyWage.MaxHrPrMonth && TotalWorkDays< companyWage.MaxWorkingDays)
            {
                TotalWorkDays++;
                Random random = new Random();
                int CheckAttenance = random.Next(0, 3);
                switch (CheckAttenance)
                {
                    case Full_Time:
                        empHrs = 8;
                        break;
                    case Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                TotalHrs += empHrs;
            }
            Console.WriteLine("Total number of Work Days "+TotalWorkDays);
            Console.WriteLine("Total work Hours "+TotalHrs);
            return TotalHrs * companyWage.WagePrHr;
        }
    }
}
