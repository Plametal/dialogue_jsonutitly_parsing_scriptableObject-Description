using UnityEngine;

public class workApp : MonoBehaviour, clickInterface
{
    public static workApp instance;
    public GameObject workArea;
    void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(this);

        workArea.setActive(false);
    }

//대충 미니 게임 하나 만들자
    public void workSpace()
    {
        workArea.setActive(true);
    }
}