namespace GESYNDICAT.VUE
{
    partial class F_listeadherent
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
            this.BTNACTUALISER = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridadherent1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridadherent1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNACTUALISER
            // 
            this.BTNACTUALISER.Location = new System.Drawing.Point(146, 56);
            this.BTNACTUALISER.Margin = new System.Windows.Forms.Padding(2);
            this.BTNACTUALISER.Name = "BTNACTUALISER";
            this.BTNACTUALISER.Size = new System.Drawing.Size(88, 28);
            this.BTNACTUALISER.TabIndex = 101;
            this.BTNACTUALISER.Text = "ACTUALISER";
            this.BTNACTUALISER.UseVisualStyleBackColor = true;
            this.BTNACTUALISER.Click += new System.EventHandler(this.BTNACTUALISER_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(30, 56);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(93, 28);
            this.Button1.TabIndex = 100;
            this.Button1.Text = "NOUVEAU";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(507, 56);
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(174, 20);
            this.txtrecherche.TabIndex = 98;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(290, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "LISTE  DES ADHERENTS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridadherent1
            // 
            this.dataGridadherent1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridadherent1.Location = new System.Drawing.Point(12, 140);
            this.dataGridadherent1.Name = "dataGridadherent1";
            this.dataGridadherent1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridadherent1.Size = new System.Drawing.Size(717, 254);
            this.dataGridadherent1.TabIndex = 104;
            this.dataGridadherent1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridadherent1_CellClick);
            this.dataGridadherent1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridadherent1_CellContentClick);
            // 
            // F_listeadherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 403);
            this.Controls.Add(this.dataGridadherent1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTNACTUALISER);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtrecherche);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_listeadherent";
            this.Text = "F_listeadherent";
            this.Load += new System.EventHandler(this.F_listeadherent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridadherent1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BTNACTUALISER;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridadherent1;
    }
}