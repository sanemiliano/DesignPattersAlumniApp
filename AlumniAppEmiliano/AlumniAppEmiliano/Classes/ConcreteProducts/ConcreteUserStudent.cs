using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.ConcreteProducts
{
    class ConcreteUserStudent : AbstractUser
    {
        private static ConcreteUserStudent _instance = null;
        private static object _handle = new object();
        protected ConcreteUserStudent()
        {

        }
        public static ConcreteUserStudent Instance
        {
            get
            {
                lock (_handle)
                {
                    if (_instance == null)
                    {
                        _instance = new ConcreteUserStudent();
                    }
                }
                return _instance;
            }
        }
    }
}
