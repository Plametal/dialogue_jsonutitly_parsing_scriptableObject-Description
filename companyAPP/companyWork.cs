using UnityEngine;

public class companyWork : MonoBehaviour, clickInterface
{
    public static companyWork instance;
    public int[] setNum;
    public GameObject ball;
    //볼이 안에 있을 구역을 정한다
    [SerializeField] private GameObject line;
    private GameObject Instantiate_ball;
    [SerializeField] private List<GameObject> balls = new List<GameObject>();

  
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
        
        Instantiate_ball = Instantiate(ball, new Vector3(-line.position.x, line.position.y, 0),Quaternion.identity);
        Instantiate_ball.transform.localScale = Vector3.one * Random.Range(0.5f, 1.5f);
        balls.Add(Instantiate_ball);
        
    }

    public void OnClick(GameObject target)
    {
        if(balls.Contains(target))
        {
            target.SetActive(false);
        }
    }
    
}