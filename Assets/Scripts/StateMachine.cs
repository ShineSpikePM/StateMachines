using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum State
    {
        Walking,
        Idle,
        Swimming,
        Climbing
    }
    // Start is called before the first frame update
    public State currentState = State.Idle;
    Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case State.Idle: Idle(); break;
            case State.Walking: Walking(); break;
            case State.Swimming: Swimming();  break;
            case State.Climbing: Climbing(); break;
            default: break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "WaterTrigger")
        {
            currentState = State.Swimming;
        }
        else if (other.name == "MountainTrigger")
        {
            currentState = State.Climbing;
        }
    }

    void OnTriggerExit(Collider other)
    {
        currentState = State.Walking;
    }

    void Swimming()
    {
        Debug.Log("I am swimming");
    }

    void Climbing()
    {
        Debug.Log("I am climbing");
    }

    void Idle()
    {
        Debug.Log("I am Idle");
        if(lastPosition != transform.position)
        {
            currentState = State.Walking;
        }
        lastPosition = transform.position;
    }

    void Walking()
    {
        Debug.Log("I am walking");
        if (lastPosition == transform.position)
        {
            currentState = State.Idle;
        }
        lastPosition = transform.position;
    }
}
