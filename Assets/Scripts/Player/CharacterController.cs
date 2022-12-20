using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum State {Combat, Base };
public class CharacterController : MonoBehaviour
{
   
    private float moveSpeed = 7f;
    private float stoppingDistance = 1f;

    Vector3 forward, right;

    Animator animator;

    Rigidbody rb;

    State _currentState;

    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = State.Combat;
       /* forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;*/
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
           
         

                if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
                {
                    Vector3 moveDirection = (targetPosition - transform.position).normalized;
                    transform.position += moveDirection * Time.deltaTime * moveSpeed;

                }


                if (Input.GetKeyDown(KeyCode.T))
                {
                    CombatMove( new Vector3(54, 0, 35));
                
                }

         
 
        
    }

    public void Move() 
    {

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal Key"), 0, Input.GetAxis("Vertical Key"));
        Vector3 rightmovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal Key");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical Key");

        Vector3 heading = Vector3.Normalize(rightmovement + upMovement);

        transform.forward = heading;
        transform.position += rightmovement;
        transform.position += upMovement;

    }

    private void CombatMove(Vector3 targetPosition) 
    {

       
        this.targetPosition = targetPosition;
    
    }
}
