using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Doubleton : BaseClass
    {
        static Doubleton[] instances = { null, null };

        static public Doubleton Instance1()
        {
            if (instances[0] == null)
            {
                instances[0] = new Doubleton();
            }

            return instances[0];
        }

        static public Doubleton Instance2()
        {
            if (instances[1] == null)
            {
                instances[1] = new Doubleton();
            }

            return instances[1];
        }

        static public int InstanceCount()
        {
            int notNullCount = 0;

            foreach(Doubleton db in instances)
            {
                if (db!=null)
                {
                    notNullCount++;
                }
            }

            return notNullCount;
        }

        private Doubleton() { }
    }
}
