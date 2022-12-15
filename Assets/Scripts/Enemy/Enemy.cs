using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{

    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0) 
        {
            Destroy(this.gameObject);
        
        }
    }

    public void Damage(int damage)
    {
        health = health - damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player_Weapon")
        {

            Damage(5);
        }
    }

    public void EnterCombat() 
    { 
    
    
    }
}
