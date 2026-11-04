using UnityEngine;

public class glassBall : MonoBehaviour, collisionInterface
{
    public static glassBall instance;
    [SerializeField] private GameObject glassBallObj;

    void Awake()
    {
        if(instance == null) instance = this;
        
        else Destroy(this);
    }

    public void collisionEnter(Collision2D target)
    {
        if(target.gameObject.tag == "player" && Input.GetKeyDown(KeyCode.F))
        {
            //대화창 뜨면서 선택지 출력
        }
    }
}