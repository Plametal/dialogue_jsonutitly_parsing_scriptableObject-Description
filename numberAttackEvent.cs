using UnityEngine;
using UnityEngine.EventSystems;
public class numberAttackEvent : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    public static numberAttackEvent instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DonDestroyOnLoad(this);
        }

        else
        {
            Destroy(this);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData == numberAttack.instance.ball)
        {
            eventData.gameObject.setActive(false);
        }

        else
        {
            break;
        }
    }
    
        
    
}