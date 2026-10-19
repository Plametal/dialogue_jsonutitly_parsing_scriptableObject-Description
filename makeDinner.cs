using System.Numerics;
using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.UI;

public class numberAttackEvent : MonoBehaviour
{
    public static makeDinner instance;
    //이게 움직이는 빨간바
    public gameObject gaugeBar;
    //이게 바가 움직일 동선
    public slider sliderBar;
    //여기 collision됐을 때, 성공할 수 있게
    public RigidBody2D timingBar;
    private float moveSpeed;
    private Vector2 moveDirection;

    void Awake() {
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
        //나중에 while문으로 변경 가능성있음
        barPosition();
    }

    private void barSetting()
    {
        gaugeBar.position.x = Random.Range(-sliderBar.position.x, sliderBar.position.x);
        gaugeBar.position.y = sliderBar.position.y;
    }

    private void barPosition(){
        if(-timingBar.position.x == -sliderBar.position.x)
        {
            //오른쪽으로 움직이게 하기
            moveDirection = Vector2.right;
        }

        else if(timingBar.position.x == sliderBar.position.x)
        {
            //왼쪽으로 움직이게 하기
            moveDirection = Vector2.left;
        }
    }

    private void barSpeed(int stage)
    {
        barSetting();

        switch(stage){
            case 1:
                moveSpeed = 3;
                break;
            
            case 2:
                moveSpeed = 7;
                break;

            case 3:
                moveSpeed = 10;
                break;
        }
        timingBar.linerVelocity = moveSpeed * moveDirection;
        
    }

    
}