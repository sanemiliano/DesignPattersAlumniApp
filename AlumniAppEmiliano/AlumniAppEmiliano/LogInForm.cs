using Alumni.App.Db;
using Alumni.App.Db.DTO;
using AlumniAppEmiliano.Classes;
using AlumniAppEmiliano.Classes.AbstractFactories;
using AlumniAppEmiliano.Classes.ConcreteFactories;
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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            UserService verificator = new UserService();
            LogInReponseDto response = verificator.LogIn(username_textbox.Text, password_textbox.Text);
            password_textbox.Text = "";
            if (!response.HasError)
            {
                createUser(response);
            }
            else
            {
                errormessage_label.Text = "Invalid credentials, please try again";
            }
        }
        private void createUser(LogInReponseDto response)
        {
            UserDto user = response.LoggedUser;
            //We have a factory of factories for SCABILITY.
            ConcreteFactoryManager factoryManager = new ConcreteFactoryManager();
            AbstractUserFactory myFactory = factoryManager.createFactory(user);
            //Now that we have our factory we manufacture our user.
            AbstractUser createdUser = myFactory.createUser(user);
            Form menuForm = new MenuForm(createdUser);
            menuForm.Owner = this;
            menuForm.Show();
            this.Hide();
        }
    }
}
