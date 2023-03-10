using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterController : MonoBehaviour
{
   
    private float moveSpeed = 7f;
    private float stoppingDistance = 0.1f;



    [SerializeField]
    private Animator playerAnimator;

    Rigidbody rb;

 

    private Vector3 targetPosition;


    private void Awake()
    {
        targetPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
      
        rb = GetComponent<Rigidbody>();

   
    }

    // Update is called once per frame
    void Update()
    {


        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;

            float rotateSpeed = 10f;
            transform.forward = Vector3.Lerp(transform.forward, moveDirection, Time.deltaTime * rotateSpeed);
            //playerAnimator.SetBool("isWalking", true);
        }
        else 
        {
            //playerAnimator.SetBool("isWalking", false);
        }


        if (Input.GetMouseButtonDown(0))
        {
            Move(MousetoWorld.GetPosition());
        }
    }


    private void Move(Vector3 targetPosition) 
    {

       
        this.targetPosition = targetPosition;
    
    }
}
