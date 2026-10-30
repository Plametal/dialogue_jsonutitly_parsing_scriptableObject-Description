using UnityEngine;
using UnityEngine.Scene;
using UnityEngine.Generic;

//아마 glassball과 접촉해야하기 때문에 들어가는 오브젝트는 glass ball
public class someOne : MonoBehaviour {
    public static someOne instance;
    public GameObject someone;
    public GameObject glassBall;
    private bool isExit;
    public int count = 0;
    void Awake()
    {
        if(instance == null) instance = this;
        
        else Destroy(this);
    }

    

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name = "player"){
            isExit = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.name = "player"){
            isExit = true;
            //여기에 대화 출력
        }

    }
    //이제 개무시하고 그냥 지나갈 경우 -> 한 3번 정도 물어봄
    private void isExitArea(){
        
    }

    
}
