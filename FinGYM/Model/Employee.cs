using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinGYM
{
    internal class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string Gender { get; set; }

        public int Age { get; set; }

        
        public string Phone { get; set; }

        public string jobTitle { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }


        public Manger manager { get; set; }
    }
}
