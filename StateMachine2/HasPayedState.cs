using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine2
{
    class HasPayedState: State
    {
        private BallMachine _bM;

        public override void InsertCoin()
        {
            Console.WriteLine("You`ve already payed");
        }

        public override void GetBall()
        {
            Console.WriteLine("Take your ball");

            if(_bM.DecareaseBallCount() > 0) _bM.SetState(_bM.GetReadyState());
            else _bM.SetState(_bM.GetNoBallState());
        }

        public override void ReturnCoin()
        {
            Console.WriteLine("Take your coin");
            _bM.SetState(_bM.GetReadyState());
        }

        public override void AddBall()
        {

        }

        public HasPayedState(BallMachine bM)
        {
            _bM = bM;
        }
    }
}
