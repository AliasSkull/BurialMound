using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionSystem : MonoBehaviour
{
    [SerializeField] private Unit selectedUnit;
    [SerializeField] private LayerMask Unit;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (TryHandleUnitSelection()) return;
          
            GridPosition mouseGridPosition = LevelGrid.Instance.GetGridPosition(MousetoWorld.GetPosition());
            if (selectedUnit.GetMoveAction().isValidActionGridPosition(mouseGridPosition))
            {

               
                selectedUnit.GetMoveAction().Move(mouseGridPosition);
            
            }
        
        }
    }


    private bool TryHandleUnitSelection() 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, Unit))
        {

            if (raycastHit.transform.TryGetComponent<Unit>(out Unit unit))
            {
                selectedUnit = unit;
                return true;
            }
        }
        return false;
    }
}
