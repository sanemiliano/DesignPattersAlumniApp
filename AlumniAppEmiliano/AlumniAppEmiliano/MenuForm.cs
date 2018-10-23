using AlumniAppEmiliano.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumniAppEmiliano
{
    public partial class MenuForm : Form
    {
        AbstractUser user;
        public MenuForm(AbstractUser user)
        {
            InitializeComponent();
            this.user = user;
            decideButtons();
        }
        public void decideButtons()
        {
            grades_button.Visible = user.buttons[0];
            profile_button.Visible = user.buttons[1];
            downloadgrades_button.Visible = user.buttons[2];

        }
        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void grades_button_Click(object sender, EventArgs e)
        {
            Form gradesForm = new GradesForm(user);
            gradesForm.Owner = this;
            gradesForm.Show();
            this.Hide();
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            Form profileForm = new ProfileForm(user);
            profileForm.Owner = this;
            profileForm.Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void downloadgrades_button_Click(object sender, EventArgs e)
        {
            Form downloadGradesForm = new DownloadGradesForm(user);
            downloadGradesForm.Owner = this;
            downloadGradesForm.Show();
            this.Hide();
        }
    }
}
