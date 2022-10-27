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
    public partial class F_listeadherent : Form
    {
        public F_listeadherent()
        {
            InitializeComponent();
        }
        AdherentDAO ad= new AdherentDAO();
        Adherent adherent = new Adherent();

        private void F_listeadherent_Load(object sender, EventArgs e)
        {
            chargeauto();
            //charge();
        }
       public   void charge()
    {
         OdbcDataReader adherent = ad.lister();
         int i = 0 ;
        
            dataGridadherent1.Rows.Clear();
           while (adherent.Read())
           {
            
                dataGridadherent1.Rows.Add();

                dataGridadherent1[0, i].Value = adherent.GetString(0);
                dataGridadherent1[1, i].Value = adherent.GetString(1);
                dataGridadherent1[2, i].Value = adherent.GetString(2);
                dataGridadherent1[3, i].Value = adherent.GetString(3);
                dataGridadherent1[4, i].Value = adherent.GetString(4);
                dataGridadherent1[5, i].Value = adherent.GetString(5);
                dataGridadherent1[6, i].Value = adherent.GetString(6);
                dataGridadherent1[7, i].Value = adherent.GetString(7);

                i = i + 1;
           }
       
        }

       private void Button1_Click(object sender, EventArgs e)
       {
           F_adherent F = new F_adherent();
           F.Show();
       }

       private void BTNACTUALISER_Click(object sender, EventArgs e)
       {
           chargeauto();
       }

       private void dataGridadherent_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           F_adherent fr = new F_adherent();
            fr.labelid.Text = this.dataGridadherent1.CurrentRow.Cells[0].Value.ToString();
           int id = int.Parse(fr.labelid.Text);
           adherent = AdherentDAO.find(id);
           if (adherent !=null)
               
           {
           fr.txtnom.Text = this.dataGridadherent1.CurrentRow.Cells[1].Value.ToString();
           fr.txtprenom.Text = this.dataGridadherent1.CurrentRow.Cells[2].Value.ToString();
           fr.txtdatenaiss.Text = this.dataGridadherent1.CurrentRow.Cells[3].Value.ToString();
           fr.txtlieunaiss.Text = this.dataGridadherent1.CurrentRow.Cells[4].Value.ToString();
           if (this.dataGridadherent1.CurrentRow.Cells[5].Value.ToString() == "Feminin" )
           {
                fr.rdfemini.Checked = true;
                fr.rdmascul.Checked = false;
           }
            else
           {
                fr.rdmascul.Checked = true;
                fr.rdfemini.Checked = false;
           }
           fr.txtcni.Text = this.dataGridadherent1.CurrentRow.Cells[6].Value.ToString();
           fr.txttel.Text = this.dataGridadherent1.CurrentRow.Cells[7].Value.ToString();
           fr.ShowDialog();
           }
       }

      

          void chargeauto(){
    DataSet ds = new DataSet();
    OdbcDataAdapter da = new OdbcDataAdapter("select * from adherent order by id desc", BDD.getconnection());
        da.Fill(ds, "adherent");
        dataGridadherent1.DataSource = ds.Tables["adherent"] ;

        BDD.closeconnection();
        da.Dispose();
    }

       private void txtrecherche_TextChanged(object sender, EventArgs e)
       {
           OdbcDataAdapter da = new OdbcDataAdapter("select * from adherent where nom  like '%" + txtrecherche.Text + "%' OR id like '%" + txtrecherche.Text + "%' OR prenom like '%" + txtrecherche.Text + "%' order by id desc ", BDD.getconnection());
     DataTable dt ;
           dt= new DataTable();

        da.Fill(dt);
        dataGridadherent1.DataSource = dt;
         BDD.closeconnection();
        da.Dispose();
          
       
       }

       private void dataGridadherent1_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           F_adherent fr = new F_adherent();
           fr.labelid.Text = this.dataGridadherent1.CurrentRow.Cells[0].Value.ToString();
           int id = int.Parse(fr.labelid.Text);
           adherent = AdherentDAO.find(id);
           if (adherent != null)
           {
               fr.txtnom.Text = this.dataGridadherent1.CurrentRow.Cells[1].Value.ToString();
               fr.txtprenom.Text = this.dataGridadherent1.CurrentRow.Cells[2].Value.ToString();
               fr.txtdatenaiss.Text = this.dataGridadherent1.CurrentRow.Cells[3].Value.ToString();
               fr.txtlieunaiss.Text = this.dataGridadherent1.CurrentRow.Cells[4].Value.ToString();
               if (this.dataGridadherent1.CurrentRow.Cells[5].Value.ToString() == "Feminin")
               {
                   fr.rdfemini.Checked = true;
                   fr.rdmascul.Checked = false;
               }
               else
               {
                   fr.rdmascul.Checked = true;
                   fr.rdfemini.Checked = false;
               }
               fr.txtcni.Text = this.dataGridadherent1.CurrentRow.Cells[6].Value.ToString();
               fr.txttel.Text = this.dataGridadherent1.CurrentRow.Cells[7].Value.ToString();
               fr.ShowDialog();
           }
       }

       private void label8_Click(object sender, EventArgs e)
       {

       }

       private void dataGridadherent1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

     
    }
}
