using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Practice
{
    public class Manager : Class1
    {
        private double food_allowance,ta;
        
        public Manager() : base()
        {
            food_allowance = 0.0;
            ta = 0.0;
        }
        public Manager(int id, string name, double salary, double food_allowance, double ta) : base(id,name,salary)
        {
            this.food_allowance = food_allowance;
            this.ta = ta;

        }
        public override void Calculate_Salary()
        {
            hra = salary * 0.40;
            Da = salary * 0.20;
            pf = salary * 0.12;
            gross = (salary + hra + Da + food_allowance + ta) - pf;
        }
        public override string ToString()
        {
            return "id = " + id + " name = " + name + " gross salary = " + gross;
        }
    }
}
