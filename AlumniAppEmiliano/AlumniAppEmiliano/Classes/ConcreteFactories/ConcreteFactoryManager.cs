using Alumni.App.Db.DTO;
using AlumniAppEmiliano.Classes.AbstractFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.ConcreteFactories
{
    class ConcreteFactoryManager
    {
        public AbstractUserFactory createFactory(UserDto user)
        {
            if (user.IdUserType == 1)
                return new ConcreteUserFactoryStudent();

            if (user.IdUserType == 2)
                return new ConcreteUserFactoryTeacher();

            return new ConcreteUserFactorySupervisor();
        }
    }
}
