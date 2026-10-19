using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.UI;

public class numberAttackEvent : MonoBehaviour
{
    public static makeDinner instance;
    public 

    void Awake() {
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

    private void barSetting()
    {
        
    }

    
}