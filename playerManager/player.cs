using UnityEngine;

//이 코드들은 나중에 추가할 부분을 정리해 놓은 부분임
public class player : MonoBehaviour, collisionInterface {
    public bool isMove;    
    public static player instance;
    //반복된 것을 진행항 시에 일어남
    public bool routineCheck = false;
    private bool prevRoutineCheck = false;
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
    //똑같은 행위ㅣ 반복
    public void getSomeTrue(bool check)
    {
        if(check)
        {
            prevRoutineCheck = check;
        }
        else
        {
            prevRoutineCheck = check;
        }
    }

    
    public void getSomeFalse(bool check)
    {
        if(check)
        {
            prevRoutineCheck = check;
        }
        else
        {
            prevRoutineCheck = check;
        }
    }

    
}