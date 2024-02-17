using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    class ConcreteProduct1 : Product
    {
        private string _info;
        public string info { get { return _info; } }

        public override string GetInfo(string info) { return info; }
        public override void Transform()
        {
            for(int i = 0;i<_info.Length - 1;i++)
            {
                if (_info[i] != ' ')
                {
                    char c = _info[i];
                    string[] inf = _info.Split(_info[i]);
                    _info = inf[0] + c + ' ';
                    for (int j = 1; j < inf.Length; j++) _info += inf[j];
                }
            }
        }
        public ConcreteProduct1(string info)
        {
            for (int i = 0; i < info.Length; i++)
            {
                _info += Char.ToLower(info[i]);
            }
        }
    }
}
