using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine2
{
    class ReadyState:State
    {
        private BallMachine _bM;

        public override void InsertCoin()
        {
            Console.WriteLine("Coin is inserted");
            _bM.SetState(_bM.GetHasPayedState());
        }

        public override void GetBall()
        {
            Console.WriteLine("You need to pay first");
        }

        public override void ReturnCoin()
        {
            Console.WriteLine("You need to pay first");
        }

        public override void AddBall()
        {

        }

        public ReadyState(BallMachine bM)
        {
            _bM = bM;
        }
    }
}
