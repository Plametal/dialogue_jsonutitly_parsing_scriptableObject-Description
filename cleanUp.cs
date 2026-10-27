using UnityEngine;
using UnityEngine.EventSystems;
public class cleanUp : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    public static cleanUp instance;
    [SerializeField] private GameObject eraser;
    [SerializeField] private GameObject erased_Object;
    [SerializeField] private GameObject area;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData){
        if(transform.name == "eraser"){
            if(eventData.position.x <= area.position.x && eventData.position.x >= -area.position.x && eventData.position.y >= -area.position.y && eventData.position.y <= area.position.y)
                transform.position = eventData.position;
        }   
    }
}