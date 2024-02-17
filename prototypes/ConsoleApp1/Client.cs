using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client
    {
        public List<Prototype> _prototypes = new List<Prototype>();
        public Prototype _prot;

        public void Operation(int id)
        {
            _prototypes.Add(_prot.Clone());
            _prototypes[_prototypes.Count - 1].ChangeId(id);
        }

        public string GetObjects()
        {
            string answer = "";

            foreach(Prototype prot in _prototypes)
            {
                answer += prot.GetInfo() + " ";
            }

            return answer;
        }

        public Client(Prototype prototype)
        {
            _prot = prototype;
        }
    }
}
