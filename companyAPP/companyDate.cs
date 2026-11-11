using UnityEngine;
public class companyDate : MonoBehaviour, clickInterface
{
    public static companyDate instance;
    public GameObject dateObj;
    void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(this);

        dateObj.setActive(false);
    }

    //간단한 달력 제작
    public void showDate(float scale)
    {
        dateObj.setActive(true);

        dateObj.localScale = Vector3.one * scale;
    }
    

    
}