using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipWeapon : MonoBehaviour
{
    public GameObject weapon;
    public GameObject handjoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        weapon.transform.parent = handjoint.transform;
        weapon.transform.localPosition = Vector3.zero;
        weapon.transform.localPosition = new Vector3(0.645777166f, 0.0804379284f, 0.0359526239f);



    }
}
