using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.ConcreteProducts
{
    class ConcreteUserSupervisor : AbstractUser
    {
        private static ConcreteUserSupervisor _instance = null;
        private static object _handle = new object();
        protected ConcreteUserSupervisor()
        {

        }
        public static ConcreteUserSupervisor Instance
        {
            get
            {
                lock (_handle)
                {
                    if (_instance == null)
                    {
                        _instance = new ConcreteUserSupervisor();
                    }
                }
                return _instance;
            }
        }
    }
}
