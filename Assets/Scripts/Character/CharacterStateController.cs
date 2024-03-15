using UnityEngine;

public class CharacterStateController : MonoBehaviour
{
   public CharacterMove CharacterMove;
   public CharacterAnimController CharacterAnimController;
   public CharacterRay CharacterRay;

    private IState currentState;

    private void Start()
    {
        currentState = new MoveState();
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }
    public void SwitchState(IState state)
    {
        currentState.ExitState(this);
        currentState = state;
        currentState.EnterState(this);
    }
}
