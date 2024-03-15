using UnityEngine;

public class CharacterRay : MonoBehaviour
{
    RaycastHit hit;
    public void Ray()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out hit,2f))
        {
            IInteraction newInteraction = hit.collider.gameObject.GetComponent<IInteraction>();
            if (newInteraction!=null)
            {
                newInteraction.Execute();
            }
        }
    }
}
