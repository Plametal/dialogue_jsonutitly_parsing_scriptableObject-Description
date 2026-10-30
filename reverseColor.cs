using System.Reflection;
using UnityEngine;
using UnityEngine.Generic;
using UnityEngine.SpriteRenderer;
using UntiyEngine.UI;

public class reverseColor : MonoBehaviour {
    public static reverseColor instance;
    public SpriteRender[] blackOne;
    public SpriteRender[] whiteOne;
    public gameObject[] Objects;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DonDestroyOnLoad(this);
        }
        
        else Destroy(this);
    }    

    public void reverseColor(bool lightOn)
    {
        if (lightOn)
        {
            for(int i = 0; i < Objects.Length; i++)
            {
                Objects[i].sprite = whiteOne[i];
            }

        }

        else
        {
            for(int i = 0; i < Objects.Length; i++)
            {
                Objects[i].sprite = blackOne;
            }
        }
    }
}