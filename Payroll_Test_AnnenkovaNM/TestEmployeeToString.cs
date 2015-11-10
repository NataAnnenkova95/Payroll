using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll_AnnenkovaNM;

namespace Payroll_Test_AnnenkovaNM
{
    [TestClass]
    public class TestEmployeeToString
    {
        [TestMethod]
        public void EmployeeToString()
        {
            int empid = 1;
            Employee e = new Employee(empid, "Natasha", "Slancy");
            Assert.AreEqual("Emp#: 1 Natasha Slancy Paid by ",e.ToString());
        }
    }
}
