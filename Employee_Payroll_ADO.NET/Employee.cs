using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_ADO.NET
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string gender { get; set; }
        public string companyName { get; set; }
        public string departmentName { get; set; }
        public Int64 phoneNo { get; set; }
        public string employeeAddress { get; set; }
        public DateTime startDate { get; set; }
        public double basicPay { get; set; }
        public double deductions { get; set; }
        public double taxablePay { get; set; }
        public double incomeTax { get; set; }
        public double netPay { get; set; }
        public int companySelect { get; set; }
        public int employeeSelect { get; set; }
        public int departmentSelect { get; set; }
    }
}
