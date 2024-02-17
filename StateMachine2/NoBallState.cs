using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine2
{
    class NoBallState: State
    {
        private BallMachine _bM;

        public override void ReturnCoin()
        {
            Console.WriteLine("Sorry, balls are over");
        }

        public override void InsertCoin()
        {
            Console.WriteLine("Sorry, balls are over");
        }

        public override void GetBall()
        {
            Console.WriteLine("Sorry, balls are over");
        }

        public override void AddBall()
        {
            _bM.SetState(_bM.GetReadyState());
        }

        public NoBallState(BallMachine bM)
        {
            _bM = bM;
        }
    }
}
