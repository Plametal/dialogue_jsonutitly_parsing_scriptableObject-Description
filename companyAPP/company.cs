using UnityEngine;
using UnityEngine.Scene;
using UnityEngine.Generic;

public class company : MonoBehaviour {
    public static company instance;
    [SerializeField] private GameObject computer;
    //0번 sns, 1번 date, 2번 work, 3번 message
    [SerializeField] private GameObject[] computerApps;
    //위에 있는 것을 클릭해서 실행시키면 해당 어플에 해당하는 내용인 밑에 있는 오브젝트가 송출되는 모습
    //[SerializeField] private GameObject[] successApp;

    //효과를 주기 위한 에셋
    float scaleSpeed = 2f;
    float scale = 0f;
 
    void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(this);
    }
    //eventSystem에서 클릭한 부분을 처리할 예정 .  
    public void OnClick(GameObject obj)
    {
        scale += Time.deltaTime * scaleSpeed;

        
        //sns
        if(obj == computerApps[0])
        {
            snsApp.instance.snsSpace(scale);
        }
        //date
        else if(obj == computerApps[1])
        {
            companyDate.instance.showDate(scale);

        }
        
        //work
        else if(obj == computerApps[2])
        {
            workApp.instance.workSpace(scale);
        }

        //message
        else if(obj == computerApps[3])
        {
            messageApp.instance.messageSpace(scale);
        }
    }

    

void Update()
{
    
}
     
}