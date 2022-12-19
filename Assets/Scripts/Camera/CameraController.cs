using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _Target;

    private Vector3 _offset;


    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - _Target.transform.position;
        transform.position = _Target.transform.position + _offset;
   
    }

    private void LateUpdate()
    {
        transform.position = _Target.transform.position + _offset;
        


    }

}
