using UnityEngine;
using UnityEngine.EventSystems;
public class cleanUp : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    public static cleanUp instance;
    [SerializeField] private GameObject eraser;
    [SerializeField] private GameObject erased_Object;
    void Awake() {
        if(instance == null)
        {
            instance = this;
            DonDestoryOnLoad(this);
        }

        else
        {
            Destroy(this);
        }
    }


    public void OnPointerClick(EventSystem data)
    {
        //
    }

}