using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using GESYNDICAT.DAO;
using GESYNDICAT.MODELE;

namespace GESYNDICAT.VUE
{
    public partial class F_adherent : Form
    {
      private  Adherent adherent = null;
    
        
        public F_adherent()
        {
            InitializeComponent();
           
        }

        private void F_adherent_Load(object sender, EventArgs e)
        {
          
            adherent=new Adherent( );
         

        }
        /* ---------------------------DEBUT MESSAGE DE VALIDATION DU FORMULAIRE--------------------------------------     */

        private string validation()
        {
            string message = "";

            if (txtnom.Text == "")
            {
                message += "le nom est invalide\n";
            }
            if (txtprenom.Text == "")
            {
                message += "le prenom est invalide\n";
            }
            if (txtdatenaiss.Text == "")
            {
                message += "le date de naissance est invalide\n";
            }
            if (txtlieunaiss.Text == "")
            {
                message += "le lieu de naissance est invalide\n";
            }
            if (txtcni.Text == "")
            {
                message += "le numero de cni est invalide\n";
            }
            if (txttel.Text == "")
            {
                message += "le numero de telephone est invalide\n";
            }


            return message;

        }
        /* ---------------------------FIN MESSAGE DE VALIDATION DU FORMULAIRE--------------------------------------     */


      

        public void Form2Adherent()
        {
            adherent.id = int.Parse(labelid.Text);
            adherent.nom = txtnom.Text;
            adherent.prenom = txtprenom.Text;
            adherent.datenaiss = txtdatenaiss.Text;
            adherent.lieunaiss = txtlieunaiss.Text;
            adherent.sexe = (rdfemini.Checked) ? "Feminin" : "Masculin";
            adherent.numcni = int.Parse(txtcni.Text);
            adherent.tel = txttel.Text;
        }


        public void Adherent2Form()
        {
            labelid.Text = adherent.id.ToString();
            txtnom.Text = adherent.nom;
            txtprenom.Text = adherent.prenom;
            txtdatenaiss.Text = adherent.datenaiss;
            txtlieunaiss.Text = adherent.lieunaiss;
            if (adherent.sexe == "Feminin")
            {
                rdfemini.Checked = true;
               
            }
            else 
            {
                rdmascul.Checked = true;
             
            
            }
            txtcni.Text = adherent.numcni.ToString();
            txttel.Text = adherent.tel;
                 
        }

        private void btnenregistre_Click(object sender, EventArgs e)
        {
            string message = validation();
            if (message != "")
            {
                MessageBox.Show("enregistrement impossible pour les raisons suivantes\n" + message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Form2Adherent();
                AdherentDAO.save(adherent);
                MessageBox.Show("enregistrement effectue avec succes");
                adherent = new Adherent();
                Adherent2Form();
                txtnom.Focus();
            }
        }

       

        private void btnannule_Click(object sender, EventArgs e)
        {
            adherent = new Adherent();
            Adherent2Form();
            txtnom.Focus();
        }

        private void btnenregistre_Click_1(object sender, EventArgs e)
        {
            string message = validation();
            if (message != "")
            {
                MessageBox.Show("enregistrement impossible pour les raisons suivantes\n" + message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Form2Adherent();
                AdherentDAO.save(adherent);
                MessageBox.Show("enregistrement effectue avec succes");
                adherent = new Adherent();
                Adherent2Form();
               
                
                txtnom.Focus();
            }

        }
        


        private void btnsupdata2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(labelid.Text);
            if (id != 0)
            {

                AdherentDAO.delete(id);
                MessageBox.Show("suppression effectue avec succes");
                //chargeadherent();
                adherent = new Adherent();
                Adherent2Form();
                txtnom.Focus();
            }
        }
       
       
      
    }
}
