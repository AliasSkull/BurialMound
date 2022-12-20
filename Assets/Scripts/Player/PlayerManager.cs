using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum State {Base, Combat };
public class PlayerManager : MonoBehaviour
{
    private State _currentState;
    // Start is called before the first frame update
    void Start()
    {
        _currentState = State.Combat; 
    }

    // Update is called once per frame
    void Update()
    {
        switch (_currentState) 
        {
            case State.Base:
                gameObject.GetComponent<CharacterController>().enabled = true;
                gameObject.GetComponent<Unit>().enabled = false;

                break;

            case State.Combat:
                gameObject.GetComponent<CharacterController>().enabled = false;
                gameObject.GetComponent<Unit>().enabled = true;
                break;
        
        
        }
    }
}
