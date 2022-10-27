using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GESYNDICAT.MODELE
{
   public class Participant
    {
        public int id { get; set; }
        public Adherent adherent { get; set; }
        public Operation operation { get; set; }
        public DateTime datep { get; set; }

        //public Participant()
        //{
        //    id = 0;
        //    adherent = null;
        //    operation = null;
        //    datep = DateTime.Today;
        //}

        //public Participant(int id, Adherent adherent, Operation operation, DateTime datep)
        //{
        //   this.id = 0;
        //    this.adherent = adherent;
        //    this.operation = operation;
        //    this.datep = DateTime.Today;
        //}
    }
}
