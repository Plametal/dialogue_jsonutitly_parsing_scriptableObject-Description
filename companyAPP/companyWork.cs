using UnityEngine;
using System.Collections.Generic;

public class companyWork : MonoBehaviour, clickInterface
{
    public static companyWork instance;
    private int[] setNum;
    public GameObject ball;
    //볼이 안에 있을 구역을 정한다
    [SerializeField] private GameObject line;
    private GameObject Instantiate_ball;
    [SerializeField] private List<GameObject> balls = new List<GameObject>();
    [SerializeField] private GameObject Area;

  
    public void randomNum(int selection)
    {
        //여기서 랜덤으로 값을 받아들인다 같은 숫자는. 나올 수 없다.
        if(selection == 1)
        {
            for(int i = 0; i < 3; i++)
                setNum[i] = Random.Range(0, 100);
        }

        else if(selection == 2)
        {
            
            for(int i = 0; i < 7; i++)
                setNum[i] = Random.Range(0, 50);
        }
        


        else
        {
            for(int i = 0; i < 10; i++)
                setNum[i] = Random.Range(0, 30);
        }    
        setNum.Sort();
        summonBall();
        ballSetting();
    }

    private void summonBall()
    {
        
        Instantiate_ball = Instantiate(ball, new Vector3(-line.transform.position.x, line.transform.position.y, 0),Quaternion.identity);
        Instantiate_ball.transform.localScale = Vector3.one * Random.Range(0.5f, 1.5f);
        balls.Add(Instantiate_ball);
    
    }

    //복제된 공에 이름을 붙여서 제거하게 하는 것
    private void ballSetting()
    {
        for(int i = 0; i < balls.Count; i++){
            balls[i].name = setNum[i];
        }
    }

    public void OnClick(GameObject target)
    {
        if(balls.Contains(target))
        {
            if(target != balls[balls.Count - 1])
            {
                //여기 안돼는 표시 나타나게 하기
                break;
            }

            else
            {
                balls.Remove(target);
                target.SetActive(false);    
            }
            
        }
    }
    
}