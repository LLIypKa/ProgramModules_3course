using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine2
{
    class BallMachine
    {
        private int _ballCount;
        private ReadyState _ready;
        private HasPayedState _hasPayed;
        private NoBallState _noBall;
        private State _currentState;

        public void SetState(State st)
        {
            _currentState = st;
        }

        public void InsertCoin()
        {
            _currentState.InsertCoin();
        }

        public void GetBall()
        {
            _currentState.GetBall();
        }

        public void ReturnCoin()
        {
            _currentState.ReturnCoin();
        }

        public void AddBall()
        {
            _currentState.AddBall();
            Console.WriteLine("Ball is Added");
            _ballCount += 1;
        }

        public int DecareaseBallCount()
        {
            _ballCount -= 1;
            return _ballCount;
        }

        public State GetReadyState()
        {
            return _ready;
        }

        public State GetHasPayedState()
        {
            return _hasPayed;
        }

        public State GetNoBallState()
        {
            return _noBall;
        }

        public BallMachine()
        {
            _ballCount = 3;
            _ready = new ReadyState(this);
            _hasPayed = new HasPayedState(this);
            _noBall = new NoBallState(this);
            _currentState = _ready;
        }
    }
}
