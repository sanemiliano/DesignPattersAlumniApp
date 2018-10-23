using Alumni.App.Db.DTO;
using AlumniAppEmiliano.Classes.AbstractFactories;
using AlumniAppEmiliano.Classes.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.ConcreteFactories
{
    class ConcreteUserFactoryTeacher : AbstractUserFactory
    {
        public override AbstractUser createUser(UserDto user)
        {
            ConcreteUserTeacher teacher = ConcreteUserTeacher.Instance;
            teacher.Address = user.Address;
            teacher.FullName = user.FullName;
            teacher.Password = user.Password;
            teacher.UserId = user.IdUser;
            teacher.typeId = user.IdUserType;
            teacher.Username = user.UserName;
            teacher.buttons[0] = true;
            teacher.buttons[1] = true;
            teacher.buttons[2] = false;
            return teacher;
        }
    }
}
