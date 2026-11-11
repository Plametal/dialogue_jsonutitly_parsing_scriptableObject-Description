using UnityEngine;
using UnityEngine.Scene;
using UnityEngine.Generic;
using UnityEngine.SceneManagement;

public class GameManager_key : Monobehaviour
{
    public static GameManager_key instance;


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DonDestroyOnLoad(this);
        }

        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        //해당되는 씬에서는 코드가 먹히지 않도록 한다.
        //메인 화면일 경우에나 다른 팝업창이 뜰 경우 그것만 가능하게 하는 코드
        if(scene.name  == "")
        {
            return;
        }
        //밑에 씬 내용들은 다 메인 화면이 아닌 실제 플레이 화면에서 일어남
        if (scene.name == "" && Input.GetKeyDown("ESC"))
        {
            !setting.instance.isAvailable;
        }
        
            
        

        if(scene.name == "" && Input.GetKeyDown("B"))
        {
            !inventory.instance.isAvailable;     
        }
        //여기는 회사와 관련된 부분입니다

        if(scene.name == "company")
        {
            if(Input.GetKeyDown(keyCode.Escape)){
                if (messageApp.instance.messageArea.activeSelf)
                {
                    messageArea.setActive(false);
                    return;
                }
                

                if (companyDate.instance.dateObj.activeSelf)
                {
                    companyDate.instance.dateObj.setActive(false);
                    return;
                }

                if (snsApp.instance.snsArea.activeSelf)
                {
                    snsApp.instance.snsArea.setActive(false);
                    return;
                }

                if (workApp.instance.workArea.activeSelf)
                {
                    workApp.instance.workArea.setActive(false);
                }
                //그리고 글 표시한 오브젝트도 엑티브 false
            }
        }
    }

    


}