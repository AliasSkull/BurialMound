using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemVisual : MonoBehaviour
{
    [SerializeField]
    private Transform gridSystemVisualSinglePrefab;


    private GridSystemVisualSingle[,] gridSystemVisualSingles;

    private void Start()
    {
        gridSystemVisualSingles = new GridSystemVisualSingle[LevelGrid.Instance.GetWidth(),LevelGrid.Instance.GetHeight()] ;
        for (int x = 0; x < LevelGrid.Instance.GetWidth(); x++)
        {
            for (int z = 0; z < LevelGrid.Instance.GetHeight(); z++)
            {
                GridPosition gridPosition = new GridPosition(x, z);
                Instantiate(gridSystemVisualSinglePrefab, LevelGrid.Instance.GetWorldPosition(gridPosition), Quaternion.identity);
            }
        }
    }

    public void HideAllPosiitons() 
    { 
    
    }

    public void ShowGridPositionList(List<GridPosition> gridPositionList)
    {
    
    }

}
