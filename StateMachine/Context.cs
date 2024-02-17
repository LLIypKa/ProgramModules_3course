using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StateMachine
{
    internal class Context
    {
        private string _text;
        private State _st;

        public char GetCharAt(int index)
        {
            return _text[index] ;
        }

        public void SetState(State state)
        {
            _st = state;
        }

        public string Request()
        {
            return _st.Handle();
        }

        public Context(string text)
        {
            _text = text;
            _st = new ConcreteStateNormal(0, this);
        }
    }
}
