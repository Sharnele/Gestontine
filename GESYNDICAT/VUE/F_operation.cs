using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GESYNDICAT.DAO;
using GESYNDICAT.MODELE;
using System.Data.Odbc;

namespace GESYNDICAT.VUE
{
    public partial class F_operation : Form
    {
          private Operation operation = null;
      


        public F_operation()
        {
            InitializeComponent();
        }

        private void F_operation_Load(object sender, EventArgs e)
        {
            operation = new Operation();
           
        }
        /* ---------------------------DEBUT MESSAGE DE VALIDATION DU FORMULAIRE--------------------------------------     */

        private string validation()
        {
            string message = "";

            if (txtmontant.Text == "")
            {
                message += "le montant est invalide\n";
            }
            //if (txtreport.Text == "")
            //{
            //    message += "le report est invalide\n";
            //}
            if (txttaux.Text == "")
            {
                message += "le taux est invalide\n";
            }
            if (cbtype.Text == "")
            {
                message += "le type d'operation est invalide\n";
            }
           


            return message;

        }
        /* ---------------------------FIN MESSAGE DE VALIDATION DU FORMULAIRE--------------------------------------     */




        public void Form2Operation()
        {
            operation.id = int.Parse(labelid.Text);
            operation.montant = float.Parse (txtmontant.Text);
            operation.taux = float.Parse(txttaux.Text);
            operation.type = cbtype.Text;
            
        }
        public float reportp() {
            return (float.Parse(txtmontant.Text) * float.Parse(txttaux.Text)); 
        }


        public void Operation2Form()
        {
            labelid.Text = operation.id.ToString();
            txtmontant.Text = operation.montant.ToString();
            txttaux.Text = operation.taux.ToString();
            cbtype.Text = operation.type;

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
                Form2Operation();
                OperationDAO.save(operation);
                MessageBox.Show("enregistrement effectue avec succes");
                operation = new Operation();
               Operation2Form();
                txtmontant.Focus();
            }
        }

       

        
        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operation operation = new Operation();

            
            if (cbtype.Text == "Cotisation")
            {
                label3.Visible = false;
                txtreport.Visible = false;

            }
            else if (cbtype.Text == "Credit")
            {
                try
                {
                    label3.Visible = true;
                    txtreport.Visible = true;
                    float n = (((float.Parse(txtmontant.Text) * float.Parse(txttaux.Text))) / 100) + (float.Parse(txtmontant.Text));
                    txtreport.Text = n.ToString();
                }
                catch (Exception ex) {
                    MessageBox.Show( ex.Message + " veillez renseigner les champs");
                }
            }
            else if (cbtype.Text == "Amande") 
            
            {
                label3.Visible = false;
                txtreport.Visible = false;
            }
            else if (cbtype.Text == "Epargne")
            {
                label3.Visible = false;
                txtreport.Visible = false;
            }


        }

        private void btnsupdata2_Click(object sender, EventArgs e)
        {
            if (operation.id != 0)
            {
                OperationDAO.delete(operation.id);
                MessageBox.Show("suppression effectue avec succes");
                operation = new Operation();
                Operation2Form();
                txtmontant.Focus();
            }

        }

        private void btnannule_Click(object sender, EventArgs e)
        {
            operation = new Operation();
            Operation2Form();
            txtmontant.Focus();
        }

     
    }
}
