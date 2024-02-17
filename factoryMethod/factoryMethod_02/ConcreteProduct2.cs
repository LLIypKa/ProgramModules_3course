using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod_02
{
    class ConcreteProduct2: ConcreteProduct1
    {
        private string _info;

        public string info { get { return _info; } }
        public override string GetInfo(string info) { return info; }
        public override void Transform()
        {
            base.Transform();
            _info += "==";
            string temp = _info.Insert(0, "==");
            _info = temp;
        }
        public ConcreteProduct2(string info):base(info)
        {
            for (int i = 0; i < info.Length; i++)
            {
                if (i == 0) _info += Char.ToUpper(info[i]);
                else _info += Char.ToLower(info[i]);
            }
        }
    }
}
