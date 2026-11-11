using System.Security.Principal;
using UnityEngine;

//이 코드들은 나중에 추가할 부분을 정리해 놓은 부분임
public class player : MonoBehaviour, collisionInterface {
    public bool isMove;    
    public static player instance;
    //반복된 것을 진행항 시에 일어남
    private bool prevRoutineCheck = true;
    private bool currentRoutineCheck = false;
    private int routineCheckNum = 0;
    //이게 접근한 위치에 맞게 설정
    public List<text> touchPos;
    private List<text> checkPos = {"toilet", "livingRoom", "desk", "bed"};
    //private bool isExit

    private void Update()
    {
        if(!isMove){
            return;
        }
    }

    public void onCollisionEnter(Collision2D target){
        if(target.gameObject.tag == "object" && Input.GetKeyDown(KeyCode.F))
        {
            touchPos.push(target.name);
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



    //pc가 이동한 경로 확인용 -> 그리고 반복된 상황이 3번 연속 진행되면 엔딩으로 가는 용도
    public void routeCheck()
    {
        if(currentRoutineCheck == true && prevRoutineCheck == true)
        {
            routineCheckNum++;
            if(routineCheckNum >= 3)
            {
    
                return;
            }
            else return;
        }

        else if(currentRoutineCheck == false)
        {
            prevRoutineCheck = true;
            currentRoutineCheck = false;
            routeCheckNum = 0;
        }

        else if(routineCheckNum >= 3)
        {
            //엔딩
        }
    }



    
}