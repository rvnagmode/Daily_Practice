using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Practice
{
    public class SalesManager : Class1
    {
        private double comission,ta,fa;

        public SalesManager() : base()
        {
            comission = 0.0;
            ta = 0.0;
            fa = 0.0;
        }
        public SalesManager(int id , string name , double salary , double comission , double ta,double fa) : base(id,name,salary)
        {
            this.comission = comission;
            this.fa = fa;
            this.ta = ta;
        }
        public void Calculate_Salary()
        {
            hra = salary * 0.40;
            Da = salary * 0.20;
            pf = salary * 0.12;
            gross = (salary + hra + Da + fa + ta + comission) - pf;
        }
        public override string ToString()
        {
            return "id = " + id + " name = " + name + " gross salary = " + gross;
        }
    }
}
