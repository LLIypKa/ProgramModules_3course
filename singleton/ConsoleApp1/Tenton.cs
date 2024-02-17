using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tenton : BaseClass
    {
        static Tenton[] instances = { null, null, null
        , null, null, null, null, null, null, null,};

        static public Tenton Instances(int index)
        {
            if (index > 9 || index < 0)
            {
                return null;
            }

            if (instances[index] == null)
            {
                instances[index] = new Tenton();
            }

            return instances[index];
        }

        static public int InstanceCount()
        {
            int notNullCount = 0;

            foreach (Tenton db in instances)
            {
                if (db != null)
                {
                    notNullCount++;
                }
            }

            return notNullCount;
        }

        private Tenton() { }
    }
}
