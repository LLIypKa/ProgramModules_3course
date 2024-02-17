using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class ConcreateStateComm: State
    {
        private Context _ct;
        public int _index;

        public override string Handle()
        {
            char ch = _ct.GetCharAt(_index);

            _index++;
            if (ch == '"')
            {
                _ct.SetState(new ConcreteStateNormal(_index, _ct));
                return $"Comm:{ch}";
            }
            else if (ch == '.')
            {
                _ct.SetState(new ConcreteStateFinal());
                return $"ErrComm:.";
            }

            return $"Comm:{ch}";
        }

        public ConcreateStateComm(int index, Context ct)
        {
            _ct = ct;
            _index = index;
        }
    }
}
