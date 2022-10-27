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

namespace GESYNDICAT.VUE
{
    public partial class F_participant : Form
    {
        Participant participant=new Participant();
        public F_participant()
        {
            InitializeComponent();
        }

        

        private string validation()
        {
            string message = "";

            if (cbadherent.Text == "")
            {
                message += "adherent invalide\n";
            }
            if (cboperation.Text == "")
            {
                message += "l'operation est invalide\n";
            }
          

            return message;

        }
       

        public void Form2Participant()
        {
           
           
            participant.id = int.Parse(labelid.Text);
            participant.adherent= AdherentDAO.find2(cbadherent.Text);
            participant.operation = OperationDAO.find2(cboperation.Text);
            participant.datep = txtdatep.Value;
        }

        public void Participannt2Form()
        {
            
            labelid.Text = participant.id.ToString();
            cbadherent.Text = participant.adherent.nom;
           cboperation.Text = participant.operation.type;
            txtdatep.Value = participant.datep;
        }
        public void vider()
        {
            labelid.Text = "0" ;
            cbadherent.Text = "";
            cboperation.Text ="";
            txtdatep.Value = DateTime.Now;
        }


       

        public void Loadoperation()
        {
            List<Operation> operations = OperationDAO.findAll();
            cboperation.Items.Clear();
            cboperation.Items.Add("");
            foreach (Operation operation in operations)
            {
                cboperation.Items.Add(operation.type);
            }
        }

        public void Loadadherent()
        {
            List<Adherent> adherents = AdherentDAO.findAll();
            cbadherent.Items.Clear();
            cbadherent.Items.Add("");
            foreach (Adherent adherent in adherents)
            {
                cbadherent.Items.Add(adherent.nom);
            }
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
                Form2Participant();
                ParticipantDAO.save(participant);
                MessageBox.Show("enregistrement effectue avec succes");
               participant = new Participant();
                vider();
                
            }
        }

        private void btnsupdata2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(labelid.Text);
            if (id != 0)
            {
                ParticipantDAO.delete(id);
                MessageBox.Show("suppression effectue avec succes");
                participant = new Participant();
                Participannt2Form();
              
            }
        }

        private void btnannule_Click(object sender, EventArgs e)
        {
            participant = new Participant();
            Participannt2Form();
          
        }

        private void F_participant_Load(object sender, EventArgs e)
        {
           
            Loadadherent();
          
            Loadoperation();
        }

        private void cbadherent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
