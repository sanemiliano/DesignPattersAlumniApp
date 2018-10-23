using Alumni.App.Db;
using Alumni.App.Db.DTO;
using AlumniAppEmiliano.Classes;
using AlumniAppEmiliano.Classes.Adapters;
using AlumniAppEmiliano.Classes.Services;
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
    public partial class GradesForm : Form
    {
        AbstractUser user;
        public GradesForm(AbstractUser user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            DataBaseService service = new DataBaseService();
            grades_datagrid.DataSource = service.getGrades(user.UserId);
        }
    }
}
