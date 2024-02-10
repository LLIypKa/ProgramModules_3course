using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Label1: AbstractLabel
    {
        private string _text;

        public Label1(string text)
        {
            _text = "=";
            foreach(char s in text)
            {
                _text += Char.ToUpper(s);
            }
            _text += "=";
            this.Text = _text;
            this.Visible = true;
        }

        public override string GetControl()
        {
            return _text;
        }
    }
}
