using Alumni.App.Db.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes
{
    public class AbstractUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }      
        public int UserId { get; set; }
        public int typeId { get; set; }
        //Credentials
        public string Username { get; set; }
        public string Password { get; set; }
        public bool[] buttons = new bool[3];
    }
}
