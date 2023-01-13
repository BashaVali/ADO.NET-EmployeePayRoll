using EmployeePayRollService;

namespace EmployeePayrollService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service");
            EmployeePay pay = new EmployeePay();
            EmployeeRepository.EmpDatabase();
        }
    }
}