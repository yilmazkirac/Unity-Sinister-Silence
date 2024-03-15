public interface IState 
{
    public void EnterState(CharacterStateController Player);
    public void ExitState(CharacterStateController Player);
    public void UpdateState(CharacterStateController Player);
}
