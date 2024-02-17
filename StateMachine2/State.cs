using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine2
{
    abstract class State
    {
        public abstract void InsertCoin();
        public abstract void GetBall();
        public abstract void ReturnCoin();
        public abstract void AddBall();

    }
}
