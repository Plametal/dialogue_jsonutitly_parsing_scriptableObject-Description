using UnityEngine;
using UnityEngine.EventSystems;
public class cleanUp : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    public static cleanUp instance;
    [SerializeField] private GameObject eraser;
    [SerializeField] private GameObject erased_Object;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        //
    }

    public void OnDrag(PointerEventData eventData){
        if(transform.name == "eraser")
            transform.position = eventData.position;
    }

}