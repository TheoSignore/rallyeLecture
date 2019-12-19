using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rallyeLecture___ajout_eleves {
    public partial class form_origin : Form {
        public form_origin() {
            InitializeComponent();     
        }
        private void form_origin_Load(object sender, EventArgs e) {
            form_auth authWindow = new form_auth(this);
            authWindow.Show();
        }

        private void form_origin_Shown(object sender, EventArgs e) {
            this.Hide();
        }

        private void form_origin_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        public void displayTheThing() {
            form_add ManageWindow = new form_add(this);
            ManageWindow.Show();
        }
    }
}
