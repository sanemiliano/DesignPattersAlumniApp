using Alumni.App.Db.DTO;
using AlumniAppEmiliano.Classes.AbstractFactories;
using AlumniAppEmiliano.Classes.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlumniAppEmiliano.Classes
{
    class ConcreteUserFactoryStudent : AbstractUserFactory
    {
        public override AbstractUser createUser(UserDto user)
        {
            ConcreteUserStudent student = ConcreteUserStudent.Instance;
            student.Address = user.Address;
            student.FullName = user.FullName;
            student.Password = user.Password;
            student.UserId = user.IdUser;
            student.typeId = user.IdUserType;
            student.Username = user.UserName;
            student.buttons[0] = true;
            student.buttons[1] = true;
            student.buttons[2] = true;
            return student;
        }

    }
}
