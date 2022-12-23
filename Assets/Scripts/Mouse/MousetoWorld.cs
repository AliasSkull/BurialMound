using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousetoWorld : MonoBehaviour
{
    private static MousetoWorld instance;

    [SerializeField]
    private LayerMask mousePlaneLayermask;

    private void Awake()
    {
        instance = this;
    }


    public static Vector3 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, instance.mousePlaneLayermask);
        Debug.Log(raycastHit.point);
        return raycastHit.point;
       


    }
}
 