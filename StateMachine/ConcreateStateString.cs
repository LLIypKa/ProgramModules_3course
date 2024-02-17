using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class ConcreateStateString:State
    {
        private Context _ct;
        public int _index;

        public override string Handle()
        {
            char ch = _ct.GetCharAt(_index);

            _index++;
            if (ch == '"' || ch == '{')
            {
                _ct.SetState(new ConcreteStateNormal(_index, _ct));
                return $"String:{ch}";
            }
            else if (ch == '.')
            {
                _ct.SetState(new ConcreteStateFinal());
                return $"ErrString:{ch}";
            }

            return $"String:{ch}";
        }

        public ConcreateStateString(int index, Context ct)
        {
            _ct = ct;
            _index = index;
        }
    }
}
