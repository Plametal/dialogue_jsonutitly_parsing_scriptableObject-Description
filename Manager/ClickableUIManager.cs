using System;
using System.Collections.Generic;
using UnityEngine;

public class ClickableUIManager : MonoBehaviour, clickInterface
{
    public static ClickableUIManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void OnClick(GameObject obj)
    {
        if(obj == null)
        {
            Debug.LogWarning("OnClick: Clicked object is null.");
            return;
        }

        else if(obj.name == "setting")
        {
            
        }

        else if(obj.name == "Inventory")
        {
            
        }

        else if(obj.name == "")
        {
            
        }
    }
}