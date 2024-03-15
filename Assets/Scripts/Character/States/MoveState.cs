using UnityEngine;

public class MoveState : IState
{
    public void EnterState(CharacterStateController Player)
    {
       
    }

    public void ExitState(CharacterStateController Player)
    {

    }

    public void UpdateState(CharacterStateController Player)
    {
        Player.CharacterMove.Move();
        Player.CharacterAnimController.MoveAnim();
        if (Input.GetKeyDown(KeyCode.E))
        {
            Player.CharacterRay.Ray();
        }      
    }
}
