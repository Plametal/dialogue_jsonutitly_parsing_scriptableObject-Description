using UnityEngine;

public class UiManager : Monobehaviour
{
    public static UiManager instance;
    //셋팅 나오게해주는 거 
    public Button settingObj;
    //인벤토리 열어 주는 거
    public Button bagObj;
    public Button ex;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        else Destroy(this);
    }

    void Update()
    {
        if (settingObj.onClicked)
        {
            setting.instance.isAvailable = true;
            player.instance.isMove = false;
        }

        if (bagObj.onClicked)
        {
            inventory.instance.isAvailable = true;
            player.instance.isMove = false;
        }

        if (ex.onClicked)
        {
            player.instance.isMove = false;
        }
    }


}