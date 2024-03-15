using DG.Tweening;
using UnityEngine;

public class Door : MonoBehaviour, IInteraction
{
    private Vector3 currentAngel;
    private float angel=90;
    private float doorSpeed=1;

    private bool isOpen;
    [SerializeField] bool isLeft;
    private void Start()
    {
        currentAngel = transform.rotation.eulerAngles;
    }
    public void Execute()
    {
        if (isLeft)
        {
            if (!isOpen)
            {
                transform.DORotate(new Vector3(currentAngel.x, currentAngel.y - angel, currentAngel.z), doorSpeed);
                currentAngel = new Vector3(currentAngel.x, currentAngel.y - angel, currentAngel.z);
                isOpen = true;
            }
            else
            {
                transform.DORotate(new Vector3(currentAngel.x, currentAngel.y + angel, currentAngel.z), doorSpeed);
                currentAngel = new Vector3(currentAngel.x, currentAngel.y + angel, currentAngel.z);
                isOpen = false;
            }

        }
        else
        {
            if (!isOpen)
            {
                transform.DORotate(new Vector3(currentAngel.x, currentAngel.y + angel, currentAngel.z), doorSpeed);
                currentAngel = new Vector3(currentAngel.x, currentAngel.y + angel, currentAngel.z);
                isOpen = true;
            }
            else
            {
                transform.DORotate(new Vector3(currentAngel.x, currentAngel.y - angel, currentAngel.z), doorSpeed);
                currentAngel = new Vector3(currentAngel.x, currentAngel.y - angel, currentAngel.z);
                isOpen = false;
            }
        }
        
    }
}
