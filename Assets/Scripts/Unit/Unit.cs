using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
   

    private MoveAction moveAction;

    [SerializeField]
    private Animator playerAnimator;




    private GridPosition gridPosition;
    private void Awake()
    {
        moveAction = GetComponent<MoveAction>();

    }

    // Start is called before the first frame update
    private void Start()
    {
        GridPosition gridPosition = LevelGrid.Instance.GetGridPosition(transform.position);
        LevelGrid.Instance.AddUnitAtGridPosition(gridPosition, this);
        


    }

    // Update is called once per frame
    void Update()
    {

        GridPosition newgridPosition = LevelGrid.Instance.GetGridPosition(transform.position);
        if (newgridPosition != gridPosition)
        {
            //unit changed Position
            LevelGrid.Instance.UnitMoveGridPosition(this, gridPosition, newgridPosition);
            gridPosition = newgridPosition;
        }
    }

    public MoveAction GetMoveAction()
    {
        return moveAction;
    
    }
}
