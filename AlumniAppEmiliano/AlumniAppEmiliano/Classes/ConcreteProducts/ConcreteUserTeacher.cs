using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.ConcreteProducts
{
    class ConcreteUserTeacher : AbstractUser
    {
        private static ConcreteUserTeacher _instance = null;
        private static object _handle = new object();
        protected ConcreteUserTeacher()
        {

        }
        public static ConcreteUserTeacher Instance
        {
            get
            {
                lock (_handle)
                {
                    if (_instance == null)
                    {
                        _instance = new ConcreteUserTeacher();
                    }
                }
                return _instance;
            }
        }
    }
}
