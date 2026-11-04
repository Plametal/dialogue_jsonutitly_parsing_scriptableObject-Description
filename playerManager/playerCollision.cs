using UnityEngine;

public class playerCollision : MonoBehaviour, collisionInterface
{
    public static playerCollision instance;
    [SerializeField] private GameObject targetObj;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DonDestroyOnLoad(this);
        }

        else {
            Destroy(this);
        }
    }
    public void collisionEnter(Collision2D target)
    {
        Debug.Log("충돌 시작");
        targetObj = target.gameObject;
        
        if(targetObj.CompareTag("cleanUp"))
        {
            Debug.Log("청소할 수 있는 오브젝트와 충돌");
        }
    }

    public void collisionExit(Collision2D target)
    {
        Debug.Log("충돌 끝");
        targetObj = null;
    }

    public void collisionStay(Collision2D target)
    {
        Debug.Log("충돌 중");
        targetObj = target.gameObject;
    }
}