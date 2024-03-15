using UnityEngine;

public class CharacterAnimController : MonoBehaviour
{
  public Animator Animator;  

    public void MoveAnim()
    {
        if (Input.GetKey(KeyCode.LeftShift)&& (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            Animator.SetFloat("Speed", 1);
        }
        else if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Animator.SetFloat("Speed", 0.5f);
        }
        else
        {
            Animator.SetFloat("Speed", 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))

        {
            Animator.CrossFade("Jump", 0.1f);
        }
    }
}
