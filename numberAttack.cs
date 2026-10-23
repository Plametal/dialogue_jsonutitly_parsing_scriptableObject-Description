using UnityEngine;

public class numberAttack : MonoBehaviour
{
    public static numberAttack instance;
    public int[] setNum;
    public GameObject ball;
    //볼이 안에 있을 구역을 정한다
    [SerializeField] private GameObject line;

  
    public void randomNum(string selection)
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
        
    }

    private void summonBall()
    {
        for(int i = 0; i < setNum.Length; i++)
        {
            GameObject Instantiate_ball = Instantiate(ball, (-line.position.x, line.position.y));
            Instantiate_ball.size = Random.Range(0.5, 1.5);
        }
    }
    
}