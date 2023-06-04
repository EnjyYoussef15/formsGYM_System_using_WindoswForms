using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinGYM
{
    internal class Classes
    {
        

 
        public int ID { get; set; }
        public string name { get; set; }

        public List<Trainee> trainees { get; set; }
       
        public Manger manger { get; set; }

        //public int Traineenum { get { return trainees.Count(); } }
      

    }
}
