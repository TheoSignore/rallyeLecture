using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rallyeLecture___ajout_eleves {
    public partial class form_add : Form {
        form_origin motherWindow;
        public form_add(form_origin F1) {
            InitializeComponent();
            motherWindow = F1;
            MySqlConnection cnx;
            string sCnx;
            sCnx = String.Format("server=172.16.0.148;uid=AdminRl;database=rallyeLecture;port=3306;pwd=siojjr");
            cnx = new MySqlConnection(sCnx);
            cnx.Open();
            string requete = "select id, niveauScolaire from niveau";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = requete;
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                cb_sclrlvl.Items.Add(rdr.GetString(1));
                cb_sclrlvl.ItemHeight = rdr.GetInt32(0);
            }
        }

        private void btn_intlaunch_Click(object sender, EventArgs e) {
            int niv = cb_sclrlvl.SelectedIndex + 1;
            int year = Convert.ToInt32(tb_sclyr.Text) ;
            string selectedCsvPath = lbl_csvf.Text + "\\" +cb_csvf.SelectedItem;
            PassWordType pst;
            if ((rb_rand.Checked)||(rb_build.Checked)) {
                if (rb_rand.Checked) {
                    pst = PassWordType.aleatoire;
                }
                else {
                    pst = PassWordType.construit;
                }
                List<Eleve> leselv = LesEleves.LoadCsv(pst, selectedCsvPath);
                MySqlConnection cnx;
                string sCnx;
                sCnx = String.Format("server=172.16.0.148;uid=AdminRl;database=rallyeLecture;port=3306;pwd=siojjr");
                cnx = new MySqlConnection(sCnx);
                cnx.Open();
                string requete = "insert into classe(anneeScolaire,idNiveau) values('"+year+"',"+niv+")";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = requete;
                cmd.ExecuteNonQuery();
                requete = "select max(id) from classe";
                cmd.Connection = cnx;
                cmd.CommandText = requete;
                int idClasse = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (Eleve elv in leselv) {
                    requete = "select max(id) from aauth_users";
                    cmd.Connection = cnx;
                    cmd.CommandText = requete;
                    int idAuth = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    requete = "insert into aauth_users(email,pass) values('"+elv.Login+"','"+Hash.GetSha256FromString(elv.PassWord,Convert.ToString(idAuth))+"')";
                    cmd.Connection = cnx;
                    cmd.CommandText = requete;
                    cmd.ExecuteNonQuery();
                    requete = "insert into eleve(idClasse,nom,prenom,login,idAuth) values("+idClasse+",'"+elv.Nom+"','"+elv.Prenom+"','"+elv.Login+"',"+idAuth+")";
                    cmd.Connection = cnx;
                    cmd.CommandText = requete;
                    cmd.ExecuteNonQuery();
                }
                LesEleves.CreateCsvPasswordFile(cb_sclrlvl.SelectedText,year,leselv);
                lbl_info.Text = String.Format("Fichier {0} inséré.",cb_csvf.SelectedItem);
            }
        }

        private void btn_brwsecsv_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if (fbd.ShowDialog() == DialogResult.OK) {
                lbl_csvf.Text = fbd.SelectedPath;
                string[] allfiles = Directory.GetFiles(fbd.SelectedPath);
                for (int i = 0; i < allfiles.Length; i++) {
                    if (allfiles[i].Contains(".csv")) {
                        string[] decomposedPath = allfiles[i].Split('\\');
                        cb_csvf.Items.Add(decomposedPath[decomposedPath.Length - 1]);
                    }
                }
            }
        }

        private void form_add_FormClosed(object sender, FormClosedEventArgs e) {
            motherWindow.Close();
        }
    }
}
