using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Practice
{
    public class Class1
    {
        protected int id;
        protected string name;
        protected double salary;
        protected double hra, Da, pf, gross;

        public Class1()
        {
            id = 0;
            name = "";
            salary = 0.0;
        }
        public Class1(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
       
        public virtual void Calculate_Salary()
        {
             hra = salary * 0.40;
             Da = salary * 0.20;
             pf = salary * 0.12;
             gross = (salary + hra + Da) - pf;
        }
        public override string ToString()
        {
            return "id = " + id + " name = " + name + " Gross salary = " + gross;
        }
    }
}
