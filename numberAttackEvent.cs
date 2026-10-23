using UnityEngine;
using UnityEngine.EventSystems;
public class numberAttackEvent : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    public static numberAttackEvent instance;

    

    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.setActive(false);   
    }
    
        
    
}