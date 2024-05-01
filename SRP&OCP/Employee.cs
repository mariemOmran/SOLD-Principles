using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP
{
    // Class responsible for maintaining employee information
    public class EmployeeInfo
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }

    // Class responsible for calculating yearly salary
    public class SalaryCalculator
    {
        public decimal CalculateYearlySalary(decimal monthlySalary)
        {
            return monthlySalary * 12;
        }
    }

    // Class responsible for generating reports
    public class ReportGenerator
    {
        public void GenerateReport(string reportType)
        {
            
        }
    }

    // Class responsible for sending notifications
    public class NotificationSender
    {
        public void SendNotification(string recipient, string message)
        {
           
        }
    }

}
