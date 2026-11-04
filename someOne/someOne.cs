using UnityEngine;
using UnityEngine.Scene;
using UnityEngine.Generic;

//아마 glassball과 접촉해야하기 때문에 들어가는 오브젝트는 glass ball
public class someOne : MonoBehaviour, collisionInterface {
    public static someOne instance;
    //같은 폴더에 있는 glassball을 만지지 않고 그냥 지나가면 스택이 쌓임
    public GameObject someoneArea;
    public bool isExit;
    public int count = 0;
    void Awake()
    {
        if(instance == null) instance = this;
        
        else Destroy(this);
    }

    

    private void collisionEnter(Collision collision) {
        if(collision.gameObject.tag == "player"){
            if(isExit == true){
                return;
            }
            isExit = false;
            
        }
    }

    private void collisionExit(Collision2D collision){
        if(collision.gameObject.tag == "player"){
            isExit = true;
            count++;
            isExitArea();
            if(count >= 3)
            {
                
            }
            //여기에 대화 출력
        }

    }
    //이제 개무시하고 그냥 지나갈 경우 -> 한 3번 정도 물어봄
    private void isExitArea(){
        
    }

    
}
