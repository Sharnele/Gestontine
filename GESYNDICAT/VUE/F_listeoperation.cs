using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using GESYNDICAT.MODELE;
using GESYNDICAT.DAO;

namespace GESYNDICAT.VUE
{
    public partial class F_listeoperation : Form
    {
        Operation operation = new Operation();
        public F_listeoperation()
        {
            InitializeComponent();
        }

        void chargeauto()
        {
            DataSet ds = new DataSet();
            OdbcDataAdapter da = new OdbcDataAdapter("select * from operation order by id desc", BDD.getconnection());
            da.Fill(ds, "operation");
            dataGridoperation.DataSource = ds.Tables["operation"];

            BDD.closeconnection();
            da.Dispose();
        }
        private void btnnouveau_Click(object sender, EventArgs e)
        {
            F_operation F = new F_operation();
            F.Show();
        }

        private void BTNACTUALISER_Click(object sender, EventArgs e)
        {
            chargeauto();
        }

        private void dataGridoperation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            F_operation fr = new F_operation();
            fr.labelid.Text = this.dataGridoperation.CurrentRow.Cells[0].Value.ToString();
            int id = int.Parse(fr.labelid.Text);
            operation = OperationDAO.find(id);
            if (operation != null)
            {
                fr.txtmontant.Text = this.dataGridoperation.CurrentRow.Cells[1].Value.ToString();
                fr.txttaux.Text = this.dataGridoperation.CurrentRow.Cells[2].Value.ToString();
              
               
                if (this.dataGridoperation.CurrentRow.Cells[3].Value.ToString() == "Cotisation")
                {
                    fr.cbtype.Text = "Cotisation";
                }
                else if (this.dataGridoperation.CurrentRow.Cells[3].Value.ToString() == "Amande")
                {
                    fr.cbtype.Text = "Amande";
                }
                else if (this.dataGridoperation.CurrentRow.Cells[3].Value.ToString() == "Credit")
                {
                    fr.cbtype.Text = "Credit";
                }
                else if (this.dataGridoperation.CurrentRow.Cells[3].Value.ToString() == "Epargne")
                {
                    fr.cbtype.Text = "Epargne";
                }
                fr.ShowDialog();
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            OdbcDataAdapter da = new OdbcDataAdapter("select * from operation  where type  like '%" + txtrecherche.Text + "%' order by id desc ", BDD.getconnection());
            DataTable dt;
            dt = new DataTable();

            da.Fill(dt);
            dataGridoperation.DataSource = dt;
            BDD.closeconnection();
            da.Dispose();
        }

        private void F_listeoperation_Load(object sender, EventArgs e)
        {
            chargeauto();
        }

       
    }
}
