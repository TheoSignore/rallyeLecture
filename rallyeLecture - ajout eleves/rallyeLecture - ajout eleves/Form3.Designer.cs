namespace rallyeLecture___ajout_eleves {
    partial class form_add {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_fdir = new System.Windows.Forms.Label();
            this.lbl_csvfintg = new System.Windows.Forms.Label();
            this.lbl_schlyr = new System.Windows.Forms.Label();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.lbl_wpatype = new System.Windows.Forms.Label();
            this.tb_csvf = new System.Windows.Forms.TextBox();
            this.clb_csvf = new System.Windows.Forms.CheckedListBox();
            this.tb_sclyr = new System.Windows.Forms.TextBox();
            this.cb_sclrlvl = new System.Windows.Forms.ComboBox();
            this.rb_rand = new System.Windows.Forms.RadioButton();
            this.rb_build = new System.Windows.Forms.RadioButton();
            this.btn_intlaunch = new System.Windows.Forms.Button();
            this.btn_brwsecsv = new System.Windows.Forms.Button();
            this.lbl_eleveList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_fdir
            // 
            this.lbl_fdir.AutoSize = true;
            this.lbl_fdir.Location = new System.Drawing.Point(12, 9);
            this.lbl_fdir.Name = "lbl_fdir";
            this.lbl_fdir.Size = new System.Drawing.Size(118, 13);
            this.lbl_fdir.TabIndex = 0;
            this.lbl_fdir.Text = "Repertoire des fichiers :";
            // 
            // lbl_csvfintg
            // 
            this.lbl_csvfintg.AutoSize = true;
            this.lbl_csvfintg.Location = new System.Drawing.Point(18, 39);
            this.lbl_csvfintg.Name = "lbl_csvfintg";
            this.lbl_csvfintg.Size = new System.Drawing.Size(112, 13);
            this.lbl_csvfintg.TabIndex = 1;
            this.lbl_csvfintg.Text = "fichier CSV a integrer :";
            // 
            // lbl_schlyr
            // 
            this.lbl_schlyr.AutoSize = true;
            this.lbl_schlyr.Location = new System.Drawing.Point(53, 163);
            this.lbl_schlyr.Name = "lbl_schlyr";
            this.lbl_schlyr.Size = new System.Drawing.Size(77, 13);
            this.lbl_schlyr.TabIndex = 2;
            this.lbl_schlyr.Text = "Annee scolaire";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Location = new System.Drawing.Point(89, 197);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(41, 13);
            this.lbl_lvl.TabIndex = 3;
            this.lbl_lvl.Text = "Niveau";
            // 
            // lbl_wpatype
            // 
            this.lbl_wpatype.AutoSize = true;
            this.lbl_wpatype.Location = new System.Drawing.Point(18, 231);
            this.lbl_wpatype.Name = "lbl_wpatype";
            this.lbl_wpatype.Size = new System.Drawing.Size(112, 13);
            this.lbl_wpatype.TabIndex = 4;
            this.lbl_wpatype.Text = "Type de mot de passe";
            // 
            // tb_csvf
            // 
            this.tb_csvf.Location = new System.Drawing.Point(146, 6);
            this.tb_csvf.Name = "tb_csvf";
            this.tb_csvf.Size = new System.Drawing.Size(274, 20);
            this.tb_csvf.TabIndex = 5;
            // 
            // clb_csvf
            // 
            this.clb_csvf.FormattingEnabled = true;
            this.clb_csvf.Location = new System.Drawing.Point(146, 39);
            this.clb_csvf.Name = "clb_csvf";
            this.clb_csvf.Size = new System.Drawing.Size(355, 109);
            this.clb_csvf.TabIndex = 6;
            // 
            // tb_sclyr
            // 
            this.tb_sclyr.Location = new System.Drawing.Point(146, 160);
            this.tb_sclyr.Name = "tb_sclyr";
            this.tb_sclyr.Size = new System.Drawing.Size(100, 20);
            this.tb_sclyr.TabIndex = 7;
            // 
            // cb_sclrlvl
            // 
            this.cb_sclrlvl.FormattingEnabled = true;
            this.cb_sclrlvl.Location = new System.Drawing.Point(146, 189);
            this.cb_sclrlvl.Name = "cb_sclrlvl";
            this.cb_sclrlvl.Size = new System.Drawing.Size(121, 21);
            this.cb_sclrlvl.TabIndex = 8;
            // 
            // rb_rand
            // 
            this.rb_rand.AutoSize = true;
            this.rb_rand.Location = new System.Drawing.Point(146, 229);
            this.rb_rand.Name = "rb_rand";
            this.rb_rand.Size = new System.Drawing.Size(65, 17);
            this.rb_rand.TabIndex = 9;
            this.rb_rand.TabStop = true;
            this.rb_rand.Text = "aleatoire";
            this.rb_rand.UseVisualStyleBackColor = true;
            // 
            // rb_build
            // 
            this.rb_build.AutoSize = true;
            this.rb_build.Location = new System.Drawing.Point(252, 229);
            this.rb_build.Name = "rb_build";
            this.rb_build.Size = new System.Drawing.Size(65, 17);
            this.rb_build.TabIndex = 10;
            this.rb_build.TabStop = true;
            this.rb_build.Text = "construit";
            this.rb_build.UseVisualStyleBackColor = true;
            // 
            // btn_intlaunch
            // 
            this.btn_intlaunch.Location = new System.Drawing.Point(391, 242);
            this.btn_intlaunch.Name = "btn_intlaunch";
            this.btn_intlaunch.Size = new System.Drawing.Size(119, 23);
            this.btn_intlaunch.TabIndex = 11;
            this.btn_intlaunch.Text = "Lancer l\'integration";
            this.btn_intlaunch.UseVisualStyleBackColor = true;
            this.btn_intlaunch.Click += new System.EventHandler(this.btn_intlaunch_Click);
            // 
            // btn_brwsecsv
            // 
            this.btn_brwsecsv.Location = new System.Drawing.Point(426, 4);
            this.btn_brwsecsv.Name = "btn_brwsecsv";
            this.btn_brwsecsv.Size = new System.Drawing.Size(75, 23);
            this.btn_brwsecsv.TabIndex = 12;
            this.btn_brwsecsv.Text = "Parcourir";
            this.btn_brwsecsv.UseVisualStyleBackColor = true;
            this.btn_brwsecsv.Click += new System.EventHandler(this.btn_brwsecsv_Click);
            // 
            // lbl_eleveList
            // 
            this.lbl_eleveList.AutoSize = true;
            this.lbl_eleveList.Location = new System.Drawing.Point(536, 4);
            this.lbl_eleveList.Name = "lbl_eleveList";
            this.lbl_eleveList.Size = new System.Drawing.Size(83, 13);
            this.lbl_eleveList.TabIndex = 13;
            this.lbl_eleveList.Text = "Liste des élèves";
            // 
            // form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 522);
            this.Controls.Add(this.lbl_eleveList);
            this.Controls.Add(this.btn_brwsecsv);
            this.Controls.Add(this.btn_intlaunch);
            this.Controls.Add(this.rb_build);
            this.Controls.Add(this.rb_rand);
            this.Controls.Add(this.cb_sclrlvl);
            this.Controls.Add(this.tb_sclyr);
            this.Controls.Add(this.clb_csvf);
            this.Controls.Add(this.tb_csvf);
            this.Controls.Add(this.lbl_wpatype);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.lbl_schlyr);
            this.Controls.Add(this.lbl_csvfintg);
            this.Controls.Add(this.lbl_fdir);
            this.Name = "form_add";
            this.Text = "Ajout d\'élève";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_add_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fdir;
        private System.Windows.Forms.Label lbl_csvfintg;
        private System.Windows.Forms.Label lbl_schlyr;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.Label lbl_wpatype;
        private System.Windows.Forms.TextBox tb_csvf;
        private System.Windows.Forms.CheckedListBox clb_csvf;
        private System.Windows.Forms.TextBox tb_sclyr;
        private System.Windows.Forms.ComboBox cb_sclrlvl;
        private System.Windows.Forms.RadioButton rb_rand;
        private System.Windows.Forms.RadioButton rb_build;
        private System.Windows.Forms.Button btn_intlaunch;
        private System.Windows.Forms.Button btn_brwsecsv;
        private System.Windows.Forms.Label lbl_eleveList;
    }
}