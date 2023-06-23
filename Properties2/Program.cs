using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(01, "Vidya", 23000);
            Console.WriteLine(emp.PrintEmployee());

            Employee emp1 = new Employee(02, "Shruti", 23330, "Mumbai");
          

            Employee emp2 = new Employee(id: 202, name: "shruti", sal: 23302, city: "Kolhapur");
        }
    }
}
