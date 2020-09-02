using System;
using System.Collections.Generic;
using System.Text;

namespace M5_L56_Spli_Programs
{
    public partial class BasePlusCommissionEmployee : CommissionEmployee
    {
        // calculate earnings; override method earnings in CommissionEmployee
        //@Override                                                            
        public override double earnings()
        {
            return BaseSalary + base.earnings();
        }// end method earnings                                              

        // return string representation of BasePlusCommissionEmployee object
        //@Override                                                           
        public override string ToString()
        {

            string s = "Base-salaried-commission employee: " + Name + "\n" + "Social security number: " + Ssn +
                "\nGross sales " + string.Format("${0:0.00}", GrossSales) + "; Commission rate " + string.Format("${0:0.00}", CommissionRate) + "; Base salary " + string.Format("${0:0.00}", BaseSalary) + string.Format("\nEarned ${0:0.00}", earnings());
            return s;
        } // end method tostring    


    }
}
