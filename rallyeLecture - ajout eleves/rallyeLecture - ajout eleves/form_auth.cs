using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rallyeLecture___ajout_eleves {
    public partial class form_auth : Form {
        form_origin motherWindow;
        public form_auth(form_origin F1) {
            InitializeComponent();
            motherWindow = F1;
            motherWindow.Hide();

        }
        private void form_auth_FormClosed(object sender, FormClosedEventArgs e) {
            motherWindow.Close();
        }

        private void btn_connection_Click(object sender, EventArgs e) {
            connexionRL(tb_username.Text,tb_password.Text,motherWindow);
        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                connexionRL(tb_username.Text, tb_password.Text,motherWindow);
            }
        }

        private void connexionRL(string usr, string wpa, form_origin motherWindow) {
            MySqlConnection cnx;
            string sCnx;
            sCnx = String.Format("server=172.16.0.148;uid=AdminRl;database=rallyeLecture;port=3306;pwd=siojjr");
            cnx = new MySqlConnection(sCnx);
            try {
                cnx.Open();
            }
            catch (Exception) {
                messageError.Text = "Connexion échouée: ne pas rentrer d'identifiant.";
            }
            
            string requete = "select pass from aauth_users inner join aauth_user_to_group on aauth_users.id = aauth_user_to_group.user_id where email ='" + usr + "' and group_id = 5;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = requete;
            cmd.CommandType = System.Data.CommandType.Text;
            string hashFromBdd = (string)cmd.ExecuteScalar();
            messageError.Text = hashFromBdd;
            requete = "select id from aauth_users where email ='" + usr + "';";
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = cnx;
            cmd2.CommandText = requete;
            cmd2.CommandType = System.Data.CommandType.Text;
            string idUser = Convert.ToString(cmd2.ExecuteScalar());
            if ((idUser != null)&&(Hash.GetSha256FromString(wpa, idUser) == hashFromBdd)) {
                motherWindow.displayTheThing();
                this.Hide();
            }
            else messageError.Text = "Indentifiants invalides"; ;
        }
    }
}
