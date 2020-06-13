using System;

namespace GetSalary
{
    class Program
    {
        public static int GetWate(int baseSalary, int overTime, int rate)
        {
            return baseSalary + (overTime * rate);

        }
        static void Main(string[] args)
        {
            int baseSalary = 200;
            int overTime = 5;
            int rate = 5;
            Console.WriteLine("Hello World! procedural {0}", GetWate(baseSalary, overTime, rate));
            var employee = new Employee(baseSalary, overTime, rate);
            Console.WriteLine("Hello World! object oriented {0}", employee.GetWate());
        }

    }
    class Employee
    {
        public int baseSalary {get;  set;}
        public int overTime { get; set; }
        public int rate { get; set; }
        public Employee(int baseSalary, int overTime, int rate)
        {
            this.baseSalary = baseSalary;
            this.overTime = overTime;
            this.rate = rate;
        }

        public int GetWate()
        {
            return baseSalary + (overTime * rate);
        }

    }
}
