using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGrid : MonoBehaviour
{

    private GridManager gridManager;
    private void Start()
    {
       gridManager = new GridManager(10, 10, 2f);

        Debug.Log(new GridPosition(5,7));
    }

    private void Update()
    {
        Debug.Log(gridManager.GetGridPosition(MousetoWorld.GetPosition()));
    }
}
