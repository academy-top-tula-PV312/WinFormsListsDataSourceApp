using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsListsDataSourceApp
{
    public class Employee
    {
        static int idGlobal = 0;


        public Employee()
        {
            Id = ++idGlobal;
        }
        public int Id { get; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Age}) {Salary} rub";
        }
    }
}
