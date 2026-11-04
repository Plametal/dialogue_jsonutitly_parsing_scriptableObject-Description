using UnityEngine;

//이 코드들은 나중에 추가할 부분을 정리해 놓은 부분임
public class player : MonoBehaviour, collisionInterface {
    public bool isMove;    
    public static player instance;
    //private bool isExit

    private void Update()
    {
        if(!isMove){
            return;
        }
    }

    public void onCollisionEnter(Collision2D target){
        if(target.gameObject.tag == "Item")
        {
            //여기 F모양 UI출력하는 걸로
        }
    }

    
}