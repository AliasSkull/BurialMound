using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public void Awake()
    {
        BuildDatabase();
    }

    void BuildDatabase() 
    {
        items = new List<Item>(
              
            
            
            
            );
    
    }


}
