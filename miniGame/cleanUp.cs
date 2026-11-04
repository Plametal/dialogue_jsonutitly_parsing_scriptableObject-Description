using UnityEngine;

public class cleanUp : MonoBehaviour, clickInterface
{
    [SerializeField] private GameObject erased_Object;
    private bool isAvailable = true;
    private GameObject erase;

    public void onClick(GameObject erase)
    {
        if(this == null)
        {
            this.erase = erase;
        }
    
    }

    public void OnDrag(GameObject erase)
    {
        if(this == null)
        {
            this.erase = erase;
        }
    }


}