namespace MonthlyWageForEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the different company monthly wage daily wage is 150 part time 4hrs and full time 8hrs  using interface classes with array");
            Console.WriteLine("\n");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.AddEmpWage("Tata",20,150,20);
            employeeWage.AddEmpWage("TCS", 20, 150, 20);
            employeeWage.ComputeEmpWage();
        }
    }
}