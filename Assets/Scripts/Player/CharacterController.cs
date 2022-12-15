using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 7f;

    Vector3 forward, right;

    // Start is called before the first frame update
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Move();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = 10;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 7;

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
}