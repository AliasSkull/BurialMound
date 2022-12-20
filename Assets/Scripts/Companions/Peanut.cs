using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum States {Base, Combat };
public class Peanut : MonoBehaviour
{

    private float moveSpeed;

    [SerializeField]
    private GameObject _followtarget;

    private float targetDistance;
    private float offsetDistance = 5;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_followtarget.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            targetDistance = hit.distance;
            if (targetDistance >= offsetDistance)
            {
                moveSpeed = 7;
                transform.position = Vector3.MoveTowards(transform.position, _followtarget.transform.position, moveSpeed);
            }
            else 
            { 
                
            
            }

        
        }
    }
}
