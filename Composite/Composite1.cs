using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite1:Component
    {
        private List<Component> _children = new List<Component>();
        private char _data;

        public override void AddComponent(Component otherComponent)
        {
            _children.Add(otherComponent);
        }

        public override string Operation()
        {
            return $"{_data}({HelpForOperation()})";   
        }

        private string HelpForOperation()
        {
            string answer = "";

            foreach(Component cmp in _children)
            {
                answer += cmp.Operation();
            }

            return answer;
        }

        public Composite1(char character)
        {
            _data = character;
        }
    }
}
