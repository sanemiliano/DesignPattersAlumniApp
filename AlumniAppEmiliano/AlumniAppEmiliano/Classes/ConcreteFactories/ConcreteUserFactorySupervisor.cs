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
    class ConcreteUserFactorySupervisor : AbstractUserFactory
    {
        public override AbstractUser createUser(UserDto user)
        {
            ConcreteUserSupervisor supervisor = ConcreteUserSupervisor.Instance;
            supervisor.Address = user.Address;
            supervisor.FullName = user.FullName;
            supervisor.Password = user.Password;
            supervisor.UserId = user.IdUser;
            supervisor.typeId = user.IdUserType;
            supervisor.Username = user.UserName;
            supervisor.buttons[0] = false;
            supervisor.buttons[1] = true;
            supervisor.buttons[2] = false;
            return supervisor;
        }
    }
}
