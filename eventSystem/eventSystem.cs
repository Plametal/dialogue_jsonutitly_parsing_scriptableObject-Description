using System.Net;
using UnityEngine;
using UnityEngine.EventSystem;



public class EventSystem : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public static EventSystem instance;
    
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DonDestroy(this);
        }     

        else Destroy(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        clickInterface clickObj = GetComponent<clickInterface>();

        if (clickObj != null)
        {
            clickObj.OnClick(gameObject);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        clickInterface clickObj = GetComponent<clickInterface>();

        if (clickObj != null)
        {
            clickObj.OnDrag(gameObject);
        }
    }
}
