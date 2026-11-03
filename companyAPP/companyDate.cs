using UnityEngine;
public class companyDate : MonoBehaviour, clickInterface
{
    public static companyDate instance;
    [SerializeField] private GameObject dateObj;
    void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(this);

        dateObj.setActive(false);
    }

    //간단한 달력 제작
    private void showDate()
    {
        dateObj.setActive(true);
    }

    
}