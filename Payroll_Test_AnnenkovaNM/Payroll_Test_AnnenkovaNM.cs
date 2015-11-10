using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll_AnnenkovaNM;

namespace Payroll_Test_AnnenkovaNM
{
    [TestClass]
    public class Payroll_Test_AnnenkovaNM
    {
        [TestMethod]
        public void TestEmployee()
        {
            int empid = 1;
            Employee e = new Employee(empid, "Natasha", "Slancy");
            Assert.AreEqual("Natasha", e.Name);
            Assert.AreEqual("Slancy", e.Address);
            Assert.AreEqual(empid, e.EmpId);
        }
        [TestMethod]
        public void EmployeeToString()
        {
            int empid = 1;
            Employee e = new Employee(empid, "Natasha", "Slancy");
            Assert.AreEqual("Emp#: 1 Natasha Slancy Paid by ", e.ToString());
        }
        [TestMethod]
        public void AddSalariedEmployee()
        {
            int empid = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(empid, "Bob", "Home", 1000.00);
            t.Execute();
            Employee e = PayrollDatabase.GetEmployee(empid);
            Assert.AreEqual("Bob", e.Name);
            PaymentClassification pc = e.Classification;
            Assert.IsTrue(pc is SalariedClassification);
            SalariedClassification sc = pc as SalariedClassification;
            Assert.AreEqual(1000.00, sc.Salary, .001);
            PaymentSchedule ps = e.Schedule;
            Assert.IsTrue(ps is MonthlySchedule);
            PaymentMethod pm = e.Method;
            Assert.IsTrue(pm is HoldMethod);
        }

    }
}
