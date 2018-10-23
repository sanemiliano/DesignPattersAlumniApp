using AlumniAppEmiliano.Classes;
using AlumniAppEmiliano.Classes.Adapters;
using AlumniAppEmiliano.Classes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumniAppEmiliano
{
    public partial class DownloadGradesForm : Form
    {
        AbstractUser user;
        DataTable grades = new DataTable();
        DataBaseService service = new DataBaseService();
        public DownloadGradesForm(AbstractUser user)
        {
            InitializeComponent();
            this.user = user;
            getGrades();
            setButtons();
        }
        public void setButtons()
        {
            if (ConfigurationManager.AppSettings["downloadFormat"].Equals("docx"))
            {
                word_button.Visible = true;
                textfile_button.Visible = false;
            }
            else if (ConfigurationManager.AppSettings["downloadFormat"].Equals("txt"))
            {
                word_button.Visible = false;
                textfile_button.Visible = true;
            }
        }
        public void getGrades()
        {
            grades = service.getGrades(user.UserId);
        }
        private void word_button_Click(object sender, EventArgs e)
        {
            FileGeneratorService service = new FileGeneratorService();
            service.generateDocxFile(path_textbox.Text, grades);
            word_label.Text = "Archivo *Grades.docx descargado con exito";
        }

        private void textfile_button_Click(object sender, EventArgs e)
        {
            FileGeneratorService service = new FileGeneratorService();
            service.generateTxtFile(path_textbox.Text, grades);
            textfile_label.Text = "Archivo *Grades.txt descargado con exito";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void DownloadGradesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
