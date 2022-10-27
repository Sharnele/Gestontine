namespace GESYNDICAT.VUE
{
    partial class F_operation
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
            this.labelid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttaux = new System.Windows.Forms.TextBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.btnsupdata2 = new System.Windows.Forms.Button();
            this.btnannule = new System.Windows.Forms.Button();
            this.btnenregistre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(161, 56);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MONTANT :";
            // 
            // txtmontant
            // 
            this.txtmontant.Location = new System.Drawing.Point(164, 98);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(121, 20);
            this.txtmontant.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "REPORT:";
            // 
            // txtreport
            // 
            this.txtreport.Location = new System.Drawing.Point(164, 201);
            this.txtreport.Name = "txtreport";
            this.txtreport.ReadOnly = true;
            this.txtreport.Size = new System.Drawing.Size(121, 20);
            this.txtreport.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TAUX :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TYPE :";
            // 
            // txttaux
            // 
            this.txttaux.Location = new System.Drawing.Point(164, 124);
            this.txttaux.Name = "txttaux";
            this.txttaux.Size = new System.Drawing.Size(121, 20);
            this.txttaux.TabIndex = 8;
            // 
            // cbtype
            // 
            this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "Cotisation",
            "Credit",
            "Amande",
            "Epargne"});
            this.cbtype.Location = new System.Drawing.Point(164, 160);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 21);
            this.cbtype.TabIndex = 9;
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // btnsupdata2
            // 
            this.btnsupdata2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsupdata2.Location = new System.Drawing.Point(439, 142);
            this.btnsupdata2.Name = "btnsupdata2";
            this.btnsupdata2.Size = new System.Drawing.Size(84, 23);
            this.btnsupdata2.TabIndex = 98;
            this.btnsupdata2.Text = "SUPPRIMER";
            this.btnsupdata2.UseVisualStyleBackColor = true;
            this.btnsupdata2.Click += new System.EventHandler(this.btnsupdata2_Click);
            // 
            // btnannule
            // 
            this.btnannule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnannule.Location = new System.Drawing.Point(487, 95);
            this.btnannule.Name = "btnannule";
            this.btnannule.Size = new System.Drawing.Size(92, 23);
            this.btnannule.TabIndex = 97;
            this.btnannule.Text = "ANNULER";
            this.btnannule.UseVisualStyleBackColor = true;
            this.btnannule.Click += new System.EventHandler(this.btnannule_Click);
            // 
            // btnenregistre
            // 
            this.btnenregistre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnenregistre.Location = new System.Drawing.Point(385, 95);
            this.btnenregistre.Name = "btnenregistre";
            this.btnenregistre.Size = new System.Drawing.Size(96, 23);
            this.btnenregistre.TabIndex = 96;
            this.btnenregistre.Text = "ENREGISTRER";
            this.btnenregistre.UseVisualStyleBackColor = true;
            this.btnenregistre.Click += new System.EventHandler(this.btnenregistre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "FORMULAIRE D\'ENREGISTREMENT DES OPERATION";
            // 
            // F_operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsupdata2);
            this.Controls.Add(this.btnannule);
            this.Controls.Add(this.btnenregistre);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.txttaux);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtreport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelid);
            this.Name = "F_operation";
            this.Text = "F_operation";
            this.Load += new System.EventHandler(this.F_operation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsupdata2;
        private System.Windows.Forms.Button btnannule;
        private System.Windows.Forms.Button btnenregistre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelid;
        public System.Windows.Forms.TextBox txtmontant;
        public System.Windows.Forms.TextBox txtreport;
        public System.Windows.Forms.TextBox txttaux;
        public System.Windows.Forms.ComboBox cbtype;
    }
}