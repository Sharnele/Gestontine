namespace GESYNDICAT.VUE
{
    partial class F_participant
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbadherent = new System.Windows.Forms.ComboBox();
            this.cboperation = new System.Windows.Forms.ComboBox();
            this.txtdatep = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.btnsupdata2 = new System.Windows.Forms.Button();
            this.btnannule = new System.Windows.Forms.Button();
            this.btnenregistre = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "ADHERENT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "OPERATION :";
            // 
            // cbadherent
            // 
            this.cbadherent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbadherent.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbadherent.FormattingEnabled = true;
            this.cbadherent.Location = new System.Drawing.Point(229, 108);
            this.cbadherent.Margin = new System.Windows.Forms.Padding(4);
            this.cbadherent.Name = "cbadherent";
            this.cbadherent.Size = new System.Drawing.Size(188, 28);
            this.cbadherent.TabIndex = 39;
            this.cbadherent.SelectedIndexChanged += new System.EventHandler(this.cbadherent_SelectedIndexChanged);
            // 
            // cboperation
            // 
            this.cboperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperation.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboperation.FormattingEnabled = true;
            this.cboperation.Location = new System.Drawing.Point(229, 149);
            this.cboperation.Margin = new System.Windows.Forms.Padding(4);
            this.cboperation.Name = "cboperation";
            this.cboperation.Size = new System.Drawing.Size(188, 28);
            this.cboperation.TabIndex = 38;
            // 
            // txtdatep
            // 
            this.txtdatep.Location = new System.Drawing.Point(231, 202);
            this.txtdatep.Name = "txtdatep";
            this.txtdatep.Size = new System.Drawing.Size(186, 20);
            this.txtdatep.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(0, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "DATE DE NAISSANCE :";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelid.Location = new System.Drawing.Point(251, 68);
            this.labelid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 95;
            this.labelid.Text = "0";
            // 
            // btnsupdata2
            // 
            this.btnsupdata2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsupdata2.Location = new System.Drawing.Point(553, 167);
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
            this.btnannule.Location = new System.Drawing.Point(601, 120);
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
            this.btnenregistre.Location = new System.Drawing.Point(484, 120);
            this.btnenregistre.Name = "btnenregistre";
            this.btnenregistre.Size = new System.Drawing.Size(96, 23);
            this.btnenregistre.TabIndex = 96;
            this.btnenregistre.Text = "ENREGISTRER";
            this.btnenregistre.UseVisualStyleBackColor = true;
            this.btnenregistre.Click += new System.EventHandler(this.btnenregistre_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(146, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "FORMULAIRE D\'ENREGISTREMENT DES PARTICIPANTS";
            // 
            // F_participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 288);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsupdata2);
            this.Controls.Add(this.btnannule);
            this.Controls.Add(this.btnenregistre);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.txtdatep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbadherent);
            this.Controls.Add(this.cboperation);
            this.Name = "F_participant";
            this.Text = "F_participant";
            this.Load += new System.EventHandler(this.F_participant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbadherent;
        private System.Windows.Forms.ComboBox cboperation;
        public System.Windows.Forms.DateTimePicker txtdatep;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button btnsupdata2;
        private System.Windows.Forms.Button btnannule;
        private System.Windows.Forms.Button btnenregistre;
        private System.Windows.Forms.Label label8;
    }
}