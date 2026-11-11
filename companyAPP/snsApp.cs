using UnityEngine;

public class snsApp : MonoBehaviour, clickInterface
{
    public static snsApp instance;
    public GameObject snsArea;
    void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(this);

        snsArea.setActive(false);
    }

    //대충 인터넷페이지처럼 제작
    public void snsSpace(float scale)
    {
        scale = Mathf.Clamp(scale, 0f, 1f);
        snsArea.setActive(true);
        snsArea.localScale = Vector3.one * scale;
    }
}