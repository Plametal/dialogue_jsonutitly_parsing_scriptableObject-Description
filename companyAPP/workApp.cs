using UnityEngine;

public class workApp : MonoBehaviour, clickInterface
{
    public static workApp instance;
    public GameObject workArea;
    [SerializeField] private GameObject[] workLevel;
    void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(this);

        workArea.setActive(false);
    }

//대충 미니 게임 하나 만들자
    public void workSpace(float scale)
    {
        workArea.setActive(true);
        scale = Mathf.Clamp(scale, 0f, 1f);
        workArea.localScale = Vector3.one * scale;

    
    }

    private void OnClick(GameObject obj)
    {
        if(obj == workLevel[0])
        {
            companyWork.instance.randomNum(1); 
        }
        else if(obj == workLevel[1])
        {
            companyWork.instance.randomNum(2);
        }
        else if(obj == workLevel[2])
        {
            companyWork.instance.randomNum(3);
        }
    }
}