using UnityEngine;

public class snsApp : MonoBehaviour, clickInterface
{
    public static snsApp instance;
    [SerializeField] private GameObject snsArea;
    void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(this);

        snsArea.setActive(false);
    }

    //대충 인터넷페이지처럼 제작
    public void snsSpace()
    {
        snsArea.setActive(true);
    }
}