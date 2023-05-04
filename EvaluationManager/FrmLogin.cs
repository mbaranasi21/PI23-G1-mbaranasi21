using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EvaluationManager {
    public partial class FrmLogin : Form {
        string username = "nastavnik";
        string password = "test";
        public FrmLogin() {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e) {
            if(txtUsername.Text == "" && txtPassword.Text == "") {
                MessageBox.Show("Korisničko ime i lozinka nisu uneseni!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if (txtUsername.Text == username && txtPassword.Text == password) {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

    }
}
