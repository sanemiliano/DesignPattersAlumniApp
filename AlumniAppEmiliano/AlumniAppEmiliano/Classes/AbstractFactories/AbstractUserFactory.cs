using Alumni.App.Db.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.AbstractFactories
{
    abstract class AbstractUserFactory
    {
        public abstract AbstractUser createUser(UserDto user);
    }
}
