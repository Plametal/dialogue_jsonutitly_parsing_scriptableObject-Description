using UnityEngine;

public class numberAttack : MonoBehaviour
{
    public static numberAttack instance;
    public int[] setNum;

    void Awake()
    {
        instance = this;
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
    
}