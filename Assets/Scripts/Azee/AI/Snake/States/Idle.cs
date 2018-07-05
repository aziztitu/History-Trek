using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI.SnakeStates
{
    public class Idle : StateMachine<Snake>.State
    {
        public class StateData
        {

        }

        private static Idle _instance;

        public static Idle Instance
        {
            get { return _instance ?? (_instance = new Idle()); }
        }

        private Idle()
        {
        }

        public void Enter(Snake owner, params object[] args)
        {

        }

        public void Update(Snake owner)
        {

        }

        public void Exit(Snake owner)
        {

        }
    }
}
