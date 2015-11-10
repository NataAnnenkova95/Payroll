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
    }
}
