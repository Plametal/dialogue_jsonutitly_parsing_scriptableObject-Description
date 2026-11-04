using UnityEnigne;

public class livingRoom : MonoBehaviour, collisionInterface{
    [SerializeField] private GameObject livingRoomObj;
    
    public void collisionEnter(Collision2D target)
    {
        if(target.gameObject.tag == "player" && Input.GetKeyDown(KeyCode.F))
        {
            //대화창 뜨면서 선택지 출력
        }
    }
}