using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCulling : MonoBehaviour
{
    [SerializeField]
    private Transform _targetObject;

    [SerializeField]
    private LayerMask wallMask;

    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }


    // Update is called once per frame
    private void Update()
    {
        Vector2 cutoutPOS = mainCamera.WorldToViewportPoint(_targetObject.position);
        cutoutPOS.y /= (Screen.width / Screen.height);

        Vector3 offset = _targetObject.position - transform.position;
        RaycastHit[] hitObjs = Physics.RaycastAll(transform.position, offset, offset.magnitude, wallMask);

        for (int i = 0; i < hitObjs.Length; i++)
        {
            Material[] materials = hitObjs[i].transform.GetComponent<Renderer>().materials;

            for (int m = 0; m < materials.Length; ++m)
            {
                materials[m].SetVector("_CutoutPOS", cutoutPOS);
                materials[m].SetFloat("_CutoutSize", 0.1f);
                materials[m].SetFloat("Falloff", 0.05f);
            
            c
            }
        
        
        }
    }
}
