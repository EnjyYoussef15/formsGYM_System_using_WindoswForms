using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinGYM
{
    internal class Equipments
    {
        public int ID { get; set; }

        public string name { get; set; }

        public int totalNumber { get; set; }

        public Double price { get; set; }

        public Double totalPrice
        {
            get { return price * totalNumber; }
        }

        public DateTime DeleivryDate { get; set; }


        public Manger manager { get; set; }
    }
}
