using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_AnnenkovaNM
{
    public class HourlyClassification : PaymentClassification
    {
         private readonly double hourly;
         public HourlyClassification(double hourly)
        {
            this.hourly = hourly;
        }
         public double Hourly
         {
             get { return hourly; }
         }
         public override string ToString()
         {
             return String.Format("${0}", hourly);
         }
    }
}
