using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GESYNDICAT.MODELE
{
   public class Adherent
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string datenaiss { get; set; }
        public string lieunaiss { get; set;}
        public string sexe { get; set;}
        public int numcni { get; set; }
        public string tel { get; set; }
        public string NomComplet {
            get { return nom +  " "  + prenom; }
        }
       /* public Adherent() {
            id = 0;
            
            nom = "";
            prenom = "";
            datenaiss = "";
            lieunaiss = "";
            sexe = "";
           numcni = 0;
            tel = "";
            
        }*/

        public override string ToString()
        {
            return NomComplet;
        }
        
        

    }
    }

