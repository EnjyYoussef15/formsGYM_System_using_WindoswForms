using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinGYM
{
    internal class Trainee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        [MaxLength(11)]
        public string Phone { get; set; }
        public DateTime StartJoinDate { get; set; }

        public int Duration { get; set; }


        public DateTime EndJoinDate
        {
            get { return DateTime.Now.AddMonths(Duration); }
        }

        public double SubtractionFees { get; set; }

        //class list trainee can train with more than one Caoch (as trainee can join more than 1 class)
        //[ForeignKey("coach")]
        //public int coachID { get; set; }


        //public string coachNAme { get; set; }
        //public string ClassNAme { get; set; }

        //[ForeignKey("coach")]
        public int coachID { get; set; }
        public Coach coach { get; set; }

        public Manger manger { get; set; }

        //class list  trainee can join more than one class


        //public virtual Classes classs { get { return coach.classs; }

        [ForeignKey("clas")]

        public int clasID { get; set;  }

        public  Classes clas { get; set; }
    }
}
