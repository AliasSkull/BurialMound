using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    public static LevelGrid Instance { get; private set; }
    private GridManager gridManager;
    [SerializeField] private Transform gridPrefab;
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There is already an active instance of the LevelGrid!" + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
        gridManager = new GridManager(10, 10, 2f);
        gridManager.CreateDebugObjects(gridPrefab);
    }

    private void Update()
    {
      
    }

    public void AddUnitAtGridPosition(GridPosition gridPosition, Unit unit)
    {
        GridObject gridObject = gridManager.GetGridObject(gridPosition);
        gridObject.AddUnit(unit);
    
    }

    public List<Unit> GetUnitListAtGridPosition(GridPosition gridPosition)
    {
        GridObject gridObject = gridManager.GetGridObject(gridPosition);
        return gridObject.GetUnitList();

    }

    public void RemoveUnitAtGridPosition(GridPosition gridPosition, Unit unit)
    {
        GridObject gridObject = gridManager.GetGridObject(gridPosition);
         gridObject.RemoveUnit(unit);

    }

    public void UnitMoveGridPosition(Unit unit, GridPosition fromGridPosition, GridPosition toGridPosition)
    {
        RemoveUnitAtGridPosition(fromGridPosition, unit);
        AddUnitAtGridPosition(toGridPosition, unit);
    }

    public GridPosition GetGridPosition(Vector3 WorldPosition) => gridManager.GetGridPosition(WorldPosition);
    public Vector3 GetWorldPosition(GridPosition gridPosition) => gridManager.GetWorldPosition(gridPosition);
    public bool isValidGridPosition(GridPosition gridPosition) => gridManager.isValidGridPosition(gridPosition);

    public bool HasAnyUnitOnGridPosition(GridPosition gridPosition)
    {
        GridObject gridObject = gridManager.GetGridObject(gridPosition);
        return gridObject.HasAnyUnit();
    
    }

}
