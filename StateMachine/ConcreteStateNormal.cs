using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class ConcreteStateNormal: State
    {
        private Context _ct;
        public int _index;

        public override string Handle()
        {
            char ch = _ct.GetCharAt(_index);

            _index++;
            if (ch == '\"')
            {
                _ct.SetState(new ConcreateStateString(_index, _ct));
                return $"String:{ch}";
            }
            else if (ch == '{')
            {
                _ct.SetState(new ConcreateStateComm(_index, _ct));
                return $"Comm:{ch}";
            }
            else if (ch == '.')
            { 
                _ct.SetState(new ConcreteStateFinal()); 
                return $"Final:."; 
            }

            return $"Normal:{ch}";
        }

        public ConcreteStateNormal(int index, Context ct)
        {
            _ct = ct;
            _index = index;
        }
    }
}
