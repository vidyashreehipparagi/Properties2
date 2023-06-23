using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties2
{
    internal class Employee
    {
       //id name sal city default==>pune
       private int id ;
        private string name;
        private double sal;
        private string city;
       

        public Employee(int id, string name, double sal,string city="Pune")
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
         
        }
        public string PrintEmployee()
        {
            return $"id={id}\nname={name}\nSalary={sal}\nCity={city}";

        }

    }
}
