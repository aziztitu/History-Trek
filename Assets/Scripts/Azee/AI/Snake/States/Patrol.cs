using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AI.SnakeStates
{
    public class Patrol : StateMachine<Snake>.State
    {
        public class StateData
        {
            public Vector3 CurDir;
        }

        private static Patrol _instance;

        public static Patrol Instance
        {
            get { return _instance ?? (_instance = new Patrol()); }
        }

        private Patrol()
        {
        }

        public void Enter(Snake owner, params object[] args)
        {
            Vector3 startDir = (Vector3) args[0];
            owner.PatrolStateData = new StateData {CurDir = startDir};
        }

        public void Update(Snake owner)
        {
            owner.Controller.Move(owner.PatrolStateData.CurDir);
        }

        public void Exit(Snake owner)
        {

        }
    }
}
