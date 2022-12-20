using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum State {Combat, Base };
public class CharacterController : MonoBehaviour
{
   
    private float moveSpeed = 7f;
    private float stoppingDistance = 2f;

 

    Animator animator;

    Rigidbody rb;

    State _currentState;

    private Vector3 targetPosition;


    private void Awake()
    {
        targetPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        _currentState = State.Combat;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

   
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }


        if (Input.GetMouseButtonDown(0))
        { 

            targetPosition = MousetoWorld.GetPosition();
            Move(targetPosition);
        }
    }


    private void Move(Vector3 targetPosition) 
    {

       
        this.targetPosition = targetPosition;
    
    }
}
