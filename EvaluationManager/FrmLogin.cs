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
        public static Teacher LoggedTeacher { get; set; }
        public FrmLogin() {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e) {
            LoggedTeacher = TeacherRepository.GetTeacher(txtUsername.Text);
            if (LoggedTeacher != null && LoggedTeacher.Password == txtPassword.Text) {
                    FrmStudents frmStudents = new FrmStudents();
                    Hide();
                    frmStudents.ShowDialog();
                    Close();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

    }
