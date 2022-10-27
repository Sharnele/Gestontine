using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GESYNDICAT.MODELE
{
   public class Operation
    {
        public int id {get;set;}
        public float montant { get; set; }
        public float taux { get; set; }
        public string type { get; set; }
        public float reportp() {
            return montant * taux;
        }
        //public Operation() {
        //    id = 0;
        //   montant = 0;
        //  taux = 0;
        //    type = "";

        //}


    }
}
