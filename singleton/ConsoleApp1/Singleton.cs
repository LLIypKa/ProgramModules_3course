using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Singleton : BaseClass
    {
        static Singleton uniqueInstance = null;

        static public Singleton Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }

            return uniqueInstance;
        }

        static public int InstanceCount()
        {
            if (uniqueInstance != null)
            {
                return 1;
            }

            return 0;
        }

        private Singleton()
        {

        }
    }
}
