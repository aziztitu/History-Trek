using System.Collections;
using System.Collections.Generic;
using Azee;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    public float MoveSpeed = 2f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Move(Vector3 dir)
    {
        float delX;
        if (dir.x < 0)
        {
            delX = -MoveSpeed;
        }
        else if (dir.x > 0)
        {
            delX = MoveSpeed;
        }
        else
        {
            delX = 0;
        }

        Vector3 newPos = StaticTools.CloneVector3(transform.position);
        newPos.x += delX;
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime);
    }
}