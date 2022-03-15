using Employee_Practice;
namespace Test
{
    class Testing
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1(21,"rushi",10000);
            Console.WriteLine("Employee details : ");
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine("Gross salary of Employee : ");
            c.Calculate_Salary();
            Console.WriteLine(c);

            Console.WriteLine("*********************");
            Console.WriteLine("Manager details");
            Manager m = new Manager(7,"raj",25000,1000,1500);
            m.Calculate_Salary();
            Console.WriteLine(m);

            Console.WriteLine("************************");
            Console.WriteLine("Sales MAnager Details");
            SalesManager sm = new SalesManager(17,"suresh",40000,2000,1500,1000);
            sm.Calculate_Salary();
            Console.WriteLine(sm);

            Console.WriteLine("***************************");
            Console.WriteLine("calculation : ");
            Calculation cal = new Calculation();
            cal.Add(2,5);
            Console.WriteLine(cal);

        }
    }
}

