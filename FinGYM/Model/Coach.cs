using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinGYM
{
    internal class Coach
    {
        public int ID { get; set; }
        public string name { get; set; }

        public int age { get; set; }
        public string gender { get; set; }

        [MaxLength(11)]
        public string Phone { get; set; }

        public DateTime HireDate { get; set; }


        public double Salary { get; set; }


        //class object 1 Coach for each class

        public int classId { get; set; }
        public virtual Classes classs {get;set;}
        public string ClassName { get { return classs?.name; } }

        //class list 1 coash for many trainee
        public List<Trainee> trainees { get; set; }

       
   

    public Manger manger { get; set; }

    }
}
