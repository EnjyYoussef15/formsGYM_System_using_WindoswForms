using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinGYM
{
    internal class Manger
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public List<Trainee> trainees { get; set; }
        public List<Employee> emps { get; set; }
        public List<Coach> coachs { get; set; }

        public List<Classes> classes { get; set; }
        public List<Equipments> equipments { get; set; }

    }
}
