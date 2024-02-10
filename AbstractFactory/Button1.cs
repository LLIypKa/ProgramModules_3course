using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AbstractFactory
{
    class Button1: AbstractButton
    {
        private string _text;

        public Button1(string text) 
        {
            _text = "[";
            foreach(char s in text)
            {
                _text += Char.ToUpper(s);
            }
            _text += "]";
            this.Text = _text;
        }

        public override string GetControl()
        {
            return _text;
        }
    }
}
