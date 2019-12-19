namespace rallyeLecture___ajout_eleves {
    partial class form_auth {
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_connection = new System.Windows.Forms.Button();
            this.messageError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(30, 25);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(53, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Utilisateur";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 65);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(71, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Mot de passe";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(115, 25);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(163, 20);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(115, 65);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = ' ';
            this.tb_password.Size = new System.Drawing.Size(163, 20);
            this.tb_password.TabIndex = 3;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_password_KeyPress);
            // 
            // btn_connection
            // 
            this.btn_connection.Location = new System.Drawing.Point(317, 42);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(75, 23);
            this.btn_connection.TabIndex = 4;
            this.btn_connection.Text = "Connexion";
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // messageError
            // 
            this.messageError.AutoSize = true;
            this.messageError.Location = new System.Drawing.Point(160, 99);
            this.messageError.Name = "messageError";
            this.messageError.Size = new System.Drawing.Size(0, 13);
            this.messageError.TabIndex = 5;
            // 
            // form_auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 121);
            this.Controls.Add(this.messageError);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "form_auth";
            this.Text = "Authentification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_auth_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Label messageError;
    }
}