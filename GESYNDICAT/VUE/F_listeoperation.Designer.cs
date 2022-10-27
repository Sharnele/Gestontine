namespace GESYNDICAT.VUE
{
    partial class F_listeoperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridoperation = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNACTUALISER = new System.Windows.Forms.Button();
            this.btnnouveau = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridoperation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridoperation
            // 
            this.dataGridoperation.AllowUserToAddRows = false;
            this.dataGridoperation.AllowUserToDeleteRows = false;
            this.dataGridoperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridoperation.Location = new System.Drawing.Point(12, 144);
            this.dataGridoperation.Name = "dataGridoperation";
            this.dataGridoperation.ReadOnly = true;
            this.dataGridoperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridoperation.Size = new System.Drawing.Size(416, 254);
            this.dataGridoperation.TabIndex = 109;
            this.dataGridoperation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridoperation_CellClick);
            //this.dataGridoperation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridoperation_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(290, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "LISTE  DES OPERATIONS";
            // 
            // BTNACTUALISER
            // 
            this.BTNACTUALISER.Location = new System.Drawing.Point(146, 63);
            this.BTNACTUALISER.Margin = new System.Windows.Forms.Padding(2);
            this.BTNACTUALISER.Name = "BTNACTUALISER";
            this.BTNACTUALISER.Size = new System.Drawing.Size(88, 28);
            this.BTNACTUALISER.TabIndex = 107;
            this.BTNACTUALISER.Text = "ACTUALISER";
            this.BTNACTUALISER.UseVisualStyleBackColor = true;
            this.BTNACTUALISER.Click += new System.EventHandler(this.BTNACTUALISER_Click);
            // 
            // btnnouveau
            // 
            this.btnnouveau.Location = new System.Drawing.Point(30, 63);
            this.btnnouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btnnouveau.Name = "btnnouveau";
            this.btnnouveau.Size = new System.Drawing.Size(93, 28);
            this.btnnouveau.TabIndex = 106;
            this.btnnouveau.Text = "NOUVEAU";
            this.btnnouveau.UseVisualStyleBackColor = true;
            this.btnnouveau.Click += new System.EventHandler(this.btnnouveau_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(328, 71);
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(174, 20);
            this.txtrecherche.TabIndex = 105;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // F_listeoperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 405);
            this.Controls.Add(this.dataGridoperation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTNACTUALISER);
            this.Controls.Add(this.btnnouveau);
            this.Controls.Add(this.txtrecherche);
            this.Name = "F_listeoperation";
            this.Text = "F_listeoperation";
            this.Load += new System.EventHandler(this.F_listeoperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridoperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridoperation;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button BTNACTUALISER;
        internal System.Windows.Forms.Button btnnouveau;
        internal System.Windows.Forms.TextBox txtrecherche;
    }
}