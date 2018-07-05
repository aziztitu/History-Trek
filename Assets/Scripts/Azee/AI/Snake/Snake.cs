using System.Collections;
using System.Collections.Generic;
using AI.SnakeStates;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private StateMachine<Snake> _stateMachine;

    [HideInInspector]
    public SnakeController Controller;

    public Patrol.StateData PatrolStateData;

    void Awake()
    {
        Controller = GetComponent<SnakeController>();

        _stateMachine = new StateMachine<Snake>(this);
        _stateMachine.SwitchState(Patrol.Instance, Vector3.right);
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _stateMachine.Update();
    }


    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("DirFlipper"))
        {
            if (PatrolStateData != null)
            {
                PatrolStateData.CurDir.x *= -1;
            }
        }
    }
}