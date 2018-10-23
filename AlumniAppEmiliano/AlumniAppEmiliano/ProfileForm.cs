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
    public partial class ProfileForm : Form
    {   
        AbstractUser user;
        public ProfileForm(AbstractUser user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            fullname_label.Text = user.FullName;
            address_label.Text = user.Address;
            usertype_label.Text = Convert.ToString(user.typeId);
            username_label.Text = user.Username;
        }
    }
}
