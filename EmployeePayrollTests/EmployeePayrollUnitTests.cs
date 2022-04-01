using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee_Payroll_ADO.NET;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System;

namespace EmployeePayrollTests
{
    [TestClass]
    public class EmployeePayrollUnitTests
    {
        EmployeePayrollDatabase employeePayrollDatabase = new EmployeePayrollDatabase();
        [TestMethod]
        public void GivenEmployeeList_InAddingEmployeeMethod_ReturnSameListThatisAdded()
        {
            List<Employee> employeesListToBeAddedToDB = new List<Employee>();
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Deepa", gender = "F", phoneNo = 9034266676, employeeAddress = "VPO Hansi, Haryana", startDate = DateTime.Now, basicPay = 1800000, deductions = 250000, incomeTax = 150000, companySelect = 1, employeeSelect = 42, departmentSelect = 2, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Ramesh", gender = "M", phoneNo = 9991661664, employeeAddress = "VPO Radaur, Rajasthan", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 3, employeeSelect = 43, departmentSelect = 4, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Suresh", gender = "M", phoneNo = 9991661664, employeeAddress = "VPO Vrindavan, UP", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 2, employeeSelect = 44, departmentSelect = 3, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Harish", gender = "M", phoneNo = 9991661664, employeeAddress = "VPO Amravati, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 1, employeeSelect = 45, departmentSelect = 2, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Harinder", gender = "M", phoneNo = 9991661664, employeeAddress = "VPO Borivali, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 5, employeeSelect = 46, departmentSelect = 3, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Sidhu", gender = "M", phoneNo = 9991661664, employeeAddress = "VPO BeguSarai, MP", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 4, employeeSelect = 47, departmentSelect = 4, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Jaibhagwan", gender = "M", phoneNo = 9991661664, employeeAddress = "VPO Mohammadpur, UP", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 3, employeeSelect = 48, departmentSelect = 2, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Poonam", gender = "F", phoneNo = 9991661664, employeeAddress = "VPO Kandivali, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 2, employeeSelect = 49, departmentSelect = 4, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Manju", gender = "F", phoneNo = 9991661664, employeeAddress = "VPO Jonpur, UP", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 3, employeeSelect = 50, departmentSelect = 3, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Sapna", gender = "F", phoneNo = 9991661664, employeeAddress = "VPO Mughal Sarai, UP", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 5, employeeSelect = 51, departmentSelect = 2, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Sharda", gender = "F", phoneNo = 9991661664, employeeAddress = "VPO Jakhal, Haryana", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 1, employeeSelect = 52, departmentSelect = 1, });
            employeesListToBeAddedToDB.Add(new Employee { employeeName = "Sushma", gender = "F", phoneNo = 9991661664, employeeAddress = "VPO Nimbri, Haryana", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 4, employeeSelect = 53, departmentSelect = 3, });
            //DateTime startDateTime = DateTime.Now;
            //Console.WriteLine($"Data Addition to DB started on {startDateTime}");
            //employeePayrollDatabase.AddEmployeeListToDBWithoutThread(employeesListToBeAddedToDB);
            //DateTime endDateTime = DateTime.Now;
            //Console.WriteLine($"Data Addition to DB ended on {endDateTime}");
            //Console.WriteLine($"Time for Adding Data to DB is {endDateTime - startDateTime}");
            DateTime startDateTime1 = DateTime.Now;
            Console.WriteLine($"Data Addition to DB started on {startDateTime1}");
            employeePayrollDatabase.AddEmployeeListToDBWithThread(employeesListToBeAddedToDB);
            DateTime endDateTime1 = DateTime.Now;
            Console.WriteLine($"Data Addition to DB ended on {endDateTime1}");
            Console.WriteLine($"Time for Adding Data to DB is {endDateTime1 - startDateTime1}");
        }
    }
}